using System;
using System.Collections;
using System.Collections.Generic;
namespace bai_tap_them_tong_hop
{
    public class Forum
    {
       
       public Mylist<Post> PostList = new Mylist<Post>();
        public void AddPost(Post post)
        {
           
            PostList.Add(post);

        }
        public void UpdatePost(int id, string NewContent)
        {
            for (int i = 0; i < PostList.Count; i++)
            {
                if(PostList.list[i].ID.Equals(id))
                {
                    PostList.list[i].Content = NewContent;
                }
            }
        }
        public void RemovePost(int id)
        {
            for (int i = 0; i < PostList.Count; i++)
            {
                if(PostList.list[i].ID == id)
                {
                    PostList.Remove(PostList.list[i]);
                    break;
                }
            }
        }
        public void ShowPost()
        {
            for (int i = 0; i < PostList.Count; i++)
            {
         
                Console.WriteLine(PostList.list[i].Display());
            }
        }
        public void Seach(string name)
        {
            for (int i = 01
            ; i < PostList.Count; i++)
            {
                if(name == PostList.list[i].Author || name == PostList.list[i].Title )
                {
                    Console.WriteLine("thong tin can tim la:");
                    Console.WriteLine(PostList.list[i].Display());
                    break;
                }else
                {
                    Console.WriteLine("khong tim thay ");
                }

            }
        }
        public int SeachID(int id)
        {
            for (int i = 0; i < PostList.Count; i++)
            {
                if(id == PostList.list[i].ID)
                {
                    return i;
                }
            }
            return -1;
        }

 
    }
}