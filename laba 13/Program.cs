namespace laba_13
{
    internal class Program
    {
        class Book_realization<T> : IBook //обобщенный класс реализующий интерфейс книги
        {
            string book_name;
            string autor;
            T publish_date; //обобщенная для инт и стринг
            int numbers_of_page;
            public Book_realization(string book_name, string autor, T publish_date, int numbers_of_page)
            {
                this.book_name = book_name;
                this.autor = autor;
                this.publish_date = publish_date;
                this.numbers_of_page = numbers_of_page;

            }
            public void book_name_info() //реализованные методы интерфейса
            {
                Console.WriteLine($"Книга: {book_name}");
            }
            public void autor_info()
            {
                Console.WriteLine($"Автор: {autor}");
            }
            public void publish_date_info()
            {
                Console.WriteLine($"Дата публикации: {publish_date}");
            }
            public void number_page_info()
            {
                Console.WriteLine($"Количество страниц: {numbers_of_page}");
            }

        }
        class User<T> : IUser //обобщенный класс реализующий интерфейс пользователь
        {
            T login; //по заданию 
            string password;

            public User(T login, string password)
            {
                this.login = login;
                this.password = password;
            }

            public void login_info() //реализованные методы интерфейса
            {
                Console.WriteLine($"Логин: {login}");
            }
            public void password_info()
            {
                Console.WriteLine($"Пароль: {password}");
            }
        }
        class Shop : IUser, IBook //класс реализующий два интерфейса, пользователь и книга
        {
            string user_name;
            string book_name;

            public Shop(string user_name, string book_name)
            {
                this.user_name = user_name;
                this.book_name = book_name;
            }

            public void buy()
            {
                Console.WriteLine($"Пользователь: {user_name}, Купил книгу: {book_name}");
            }

            public void login_info() //реализованные методы интерфейса, чтобы не делать класс абстрактным 
                                     // и  создать объект класса
            {
            }
            public void password_info()
            {
            }
            public void book_name_info()
            {
            }
            public void autor_info()
            {
            }
            public void publish_date_info()
            {
            }
            public void number_page_info()
            {
            }
        }
        interface Ipublish_house //интерфейс издательство
        {
            void book_name_info();
            void autor_info();

        }
        interface IBook : Ipublish_house //интерфейс реализующий интерфейс издательство
        {
            void publish_date_info();
            void number_page_info();

        }
        interface IUser 
        {
            void login_info();
            void password_info();
        }
        static void Main(string[] args)
        {

            // два объекта класса Book_realization
            Book_realization<int> book_Realization1 = new Book_realization<int>("Комната ужасов", "Майкл Грей", 26042006, 250);
            Book_realization<string> book_Realization2 = new Book_realization<string>("Комната ужасов", "Майкл Грей", "26 апреля 2006 года", 250);

            //два объекта User
            User<string> user1 = new User<string>("Pasha", "asdfdhgfdndfi");
            User<int> user2 = new User<int>(228, "fgdgniebdtubo");

            //класс покупка
            Shop shop = new Shop("Egor", "Pomedor");
            shop.buy();
        }
 

    }
}