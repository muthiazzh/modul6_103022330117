using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022330117
{
    class SayaTubeUser 
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        string Username;

        public SayaTubeUser(string username)
        {
            Random rand = new Random();
            this.id = rand.Next(10000, 99999);
            this.uploadedVideos = new List<SayaTubeVideo>();
            Username = username;
        }

        public int GetTotalVideoPlayCount()
        {
            int totalPlay = 0;
            
            foreach (var Video in uploadedVideos){
                totalPlay += video.getPlayCount();
            }
            return GetTotalVideoPlayCount();
        }

        public void AddVideo(List<SayaTubeUser> uploadedVideos)
        {
            
            List<SayaTubeUser> uploadedVideo = new List<SayaTubeUser>();
            for ()
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine("User: " + Username);
            Console.WriteLine("Video 1 judul: " + uploadedVideos);
            Console.WriteLine("Video 2 judul: " + uploadedVideos);
        }
    }
}
