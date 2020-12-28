using System;

namespace bai_tap_them_tong_hop
{
    class Program
    {
        static void Main(string[] args)
        {
             Forum forum = new Forum();
          
            
            int choice;
            bool CheckInput = false;
            while(true)
            {
                do
                {
                    Menu();
                    CheckInput = int.TryParse(Console.ReadLine(), out choice);
                }
                    while(!CheckInput || choice < 0 || choice > 8);
                    switch(choice)
                    {
                        case 1:
                        Post post = new Post();
                      
                        Console.WriteLine("nhap title");
                        post.Title =  Console.ReadLine();
                        Console.WriteLine("nhap content");
                        post.Content = Console.ReadLine();
                        Console.WriteLine("nhap ten tac gia");
                        post.Author = Console.ReadLine();
                        forum.AddPost(post);
                        break;
                        case 2:
                        int id;
                        string NewContent;
                        Console.WriteLine("nhap id can update");
                        id =int.Parse(Console.ReadLine());
                        Console.WriteLine("nhap content moi");
                        NewContent = Console.ReadLine();
                        forum.UpdatePost(id,NewContent);
                        break;
                        case 3:
                        int RemoveID;
                        
                        do
                        {
                            Console.WriteLine("nhap id can remove");
                            CheckInput = int.TryParse(Console.ReadLine(), out RemoveID);
                        }
                        while(!CheckInput || RemoveID < 0);
                        forum.RemovePost(RemoveID);
                        break;
                        case 4:
                        forum.ShowPost();
                        break;
                        case 5:
                        string SeachName;
                        Console.WriteLine("nhap ten author hoac title");
                        SeachName = Console.ReadLine();
                        forum.Seach(SeachName);
                        break;
                        case 6:
                        int rate;
                        int InputID;
                        bool Check = false;
                       
                        do
                        {
                            Console.WriteLine("nhap id ");
                            Check = int.TryParse(Console.ReadLine(), out InputID);
                        } while (!Check || InputID <= 0);
                        int index = forum.SeachID(InputID);
                        if (index != -1)
                        {
                            do
                            {
                                Console.WriteLine("nhap danh gia ");
                                Check = int.TryParse(Console.ReadLine(), out rate);
                            } while (!Check || rate <= 0 || rate > 5);
                            forum.PostList.list[index]._rateList.Add(rate);
                            forum.PostList.list[index].CalculatorRate();
                        }
                        else Console.WriteLine("khong co"); 
                        break;
                        case 7:
                        Environment.Exit(0);
                        break;


                    }
                
            }
           
           

        }
        static void Menu()
        {
             System.Console.WriteLine("=============menu===========");
            System.Console.WriteLine("1: Add Post ");
            System.Console.WriteLine("2:Update Post ");
            System.Console.WriteLine("3 Remove Post ");
            System.Console.WriteLine("4  Show Posts ");
            System.Console.WriteLine("5.  Search ");
            System.Console.WriteLine("6. Rating ");
            System.Console.WriteLine("7. exit");
        }
    }
}
