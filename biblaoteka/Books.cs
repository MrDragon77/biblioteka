using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Books
{
    using System;
    using System.Drawing;
    using static Books.Book;

    public class Book
    {
        public string name, author, isd;
        public int amount = 0, genre = 0, id = 0;
        public Book () 
        {
            name = " ";
            author = " ";
            isd = " ";
            amount = 0;
            genre = 0;
            id = 0;
        }
        public Book(int new_id)
        {
            name = " ";
            author = " ";
            isd = " ";
            amount = 0;
            genre = 0;
            id = new_id;
        }
        public Book(string new_name, string new_author, string new_isd, int new_genre, int new_amount)
        {
            name = new_name;
            author = new_author;
            isd = new_isd;
            amount = new_amount;
            genre = new_genre;
            id = 0;
        }
        public Book(string new_name, string new_author, string new_isd, int new_genre, int new_amount, int new_id)
        {
            name = new_name;
            author = new_author;
            isd = new_isd;
            amount = new_amount;
            genre = new_genre;
            id = new_id;
        }

        public int GenreToReturnDate()
        {
            switch (genre)
            {
                case 1:
                    return 21;
                case 2:
                    return 14;
                case 3:
                    return 14;
            }
            return 14;
        }
        public string IntToGenre(int genre)
        {
            switch (genre)
            {
                case 1:
                    return "Роман";
                case 2:
                    return "Комедия";
                case 3:
                    return "Драма";
            }
            return "Неизвестен";
        }

        public int GenreToInt(string genre)
        {
            switch (genre)
            {
                case "Роман":
                    return 1;
                case "Комедия":
                    return 2;
                case "Драма":
                    return 3;
            }
            return 0;
        }

        public void Save(StreamWriter file)
        {
            file.WriteLine("Id: " + id + " Название: " + name.Replace(' ', '$') +  " Автор: " + author.Replace(' ', '$') + " Издание: " + isd.Replace(' ', '$') + " Количество: "
            + amount.ToString() + " Жанр: " + IntToGenre(genre));
        }

        public void Load(StreamReader file)
        {
            string[] args = file.ReadLine().Split(' ');
            id = Int32.Parse(args[1]);
            name = args[3].Replace('$', ' ');
            author = args[5].Replace('$', ' ');
            isd = args[7].Replace('$', ' ');
            amount = Int32.Parse(args[9]);
            genre = GenreToInt(args[11]);
        }
    }

    public class MyStorage<T>
    {
        protected class Node<T>
        {
            public Node() { }
            public Node(T data)
            {
                data = data;
            }
            public T data { get; set; }
            public Node<T> next { get; set; }
            public Node<T> prev { get; set; }

        }
        int ListSize;
        protected Node<T> CurNode;
        Node<T> head;
        Node<T> tail;
        void getByPos(int pos)
        {
            if (pos >= ListSize - 1)
                CurNode = tail;
            else if (pos <= 0)
                CurNode = head;
            else
            {
                int ListPos = 0;
                CurNode = head;
                while (ListPos != pos)
                {
                    CurNode = CurNode.next;
                    ListPos++;
                }
            }
        }

        public virtual void push_back(T elem)
        {
            Node<T> CurrNode = new Node<T>();
            CurrNode.next = null;
            CurrNode.data = elem;
            if (head != null)
            {
                CurrNode.prev = tail;
                tail.next = CurrNode;
                tail = CurrNode;
            }
            else
            {
                CurrNode.prev = null;
                head = tail = CurrNode;
            }
            ListSize++;
            CurNode = CurrNode;
        }

        public virtual void push_front(T elem)
        {
            Node<T> CurrNode = new Node<T>();
            CurrNode.data = elem;
            if (head != null)
            {
                CurrNode.next = head;
                head.prev = CurNode;
                head = CurNode;
            }
            else
            {
                CurrNode.next = null;
                head = tail = CurrNode;
            }
            CurrNode.prev = null;
            ListSize++;
            CurNode = CurrNode;
        }

        public virtual void insert(T elem)
        {
            if (CurNode == tail)
                push_back(elem);
            else if (CurNode == head)
                push_front(elem);
            else
            {
                Node<T> next_Node = CurNode.next;
                Node<T> new_Node = new Node<T>();
                new_Node.data = elem;
                CurNode.next = new_Node;
                new_Node.prev = CurNode;
                new_Node.next = next_Node;
                next_Node.prev = new_Node;
                CurNode = new_Node;
                ListSize++;
            }
        }

        public virtual void insertByPos(T elem, int pos)
        {
            getByPos(pos);
            insert(elem);
        }
        public virtual bool Find(T elem)
        {
            CurNode = head;
            int ListPos = 0;
            while (CurNode != null && CurNode.data.Equals(elem) == false)
            {
                CurNode = CurNode.next;
                ListPos++;
            }
            if (CurNode == null)
            {
                return false;
            }
            return true;
        }

        public virtual void Delete(T elem)
        {
            if (Find(elem))
            {
                DeleteCurrent();
            }
        }
        public virtual void DeleteCurrent()
        {
            if (head != null && CurNode != null)
            {
                if (CurNode == head)
                {
                    if (CurNode == tail)
                    {
                        head = null;
                        tail = null;
                        CurNode = null;
                    }
                    else
                    {
                        head = CurNode.next;
                        head.prev = null;
                        CurNode = head;
                    }
                }
                else if (CurNode == tail)
                {
                    tail = CurNode.prev;
                    CurNode = tail;
                    tail.next = null;
                }
                else
                {
                    CurNode.prev.next = CurNode.next;
                    CurNode.next.prev = CurNode.prev;
                    CurNode = CurNode.next;
                }
                ListSize--;
            }
        }

        public virtual void DeleteAtPos(int pos)
        {
            getByPos(pos);
            DeleteCurrent();
        }

        public T getData()
        {
            return CurNode.data;
        }

        public int size()
        {
            return ListSize;
        }


        public void to_beginning()
        {
            getByPos(0);
        }

        public void to_end()
        {
            getByPos(ListSize - 1);
        }

        public bool next()
        {
            if (CurNode.next != null)
            {
                CurNode = CurNode.next;
                return true;
            }
            return false;
        }

        public bool prev()
        {
            if (CurNode.prev != null)
            {
                CurNode = CurNode.prev;
                return true;
            }
            return false;
        }

        ~MyStorage()
        { }
    };
    public class MyBookStorage<T> : MyStorage<T> where T : Book
    {
        public MyBookStorage() : base()
        {
           
        }

        public MyBookStorage<Book> FindByName (string needed_name)
        {
            to_beginning();
            MyBookStorage<Book> new_storage = new MyBookStorage<Book>();
            int ListPos = 0;
            while (CurNode != null)
            {
                if (CurNode.data.name.ToLower().Contains(needed_name.ToLower()))
                {
                    new_storage.push_back(CurNode.data);
                }
                CurNode = CurNode.next;
                ListPos++;
            }
            
            return new_storage;
        }
        public Book FindById(int id)
        {
            to_beginning();
            Book book = new Book();
            int ListPos = 0;
            while (CurNode != null)
            {
                if (CurNode.data.id == id)
                {
                    return CurNode.data;
                }
                CurNode = CurNode.next;
                ListPos++;
            }
            return null;
        }
        public MyBookStorage<Book> FindByAuthor(string needed_author)
        {
            to_beginning();
            MyBookStorage<Book> new_storage = new MyBookStorage<Book>();
            int ListPos = 0;
            while (CurNode != null)
            {
                if (CurNode.data.author.ToLower().Contains(needed_author.ToLower()))
                {
                    new_storage.push_back(CurNode.data);
                }
                CurNode = CurNode.next;
                ListPos++;
            }

            return new_storage;
        }
        public MyBookStorage<Book> FindByIsd(string needed_isd)
        {
            to_beginning();
            MyBookStorage<Book> new_storage = new MyBookStorage<Book>();
            int ListPos = 0;
            while (CurNode != null)
            {
                if (CurNode.data.isd.ToLower().Contains(needed_isd.ToLower()))
                {
                    new_storage.push_back(CurNode.data);
                }
                CurNode = CurNode.next;
                ListPos++;
            }

            return new_storage;
        }
        public MyBookStorage<Book> FindByGenre(int needed_genre)
        {
            to_beginning();
            MyBookStorage<Book> new_storage = new MyBookStorage<Book>();
            int ListPos = 0;
            while (CurNode != null)
            {
                if (CurNode.data.genre == needed_genre || needed_genre == 0)
                {
                    new_storage.push_back(CurNode.data);
                }
                CurNode = CurNode.next;
                ListPos++;
            }

            return new_storage;
        }
        public bool Find (Book book)
        {
            to_beginning();
            int ListPos = 0;
            while (CurNode != null)
            {
                if (CurNode.data.name == book.name && CurNode.data.author == book.author &&
                    CurNode.data.isd == book.isd && CurNode.data.genre == book.genre)
                {
                    return true;
                }
                CurNode = CurNode.next;
                ListPos++;
            }
            return false;
        }
    } 

}
