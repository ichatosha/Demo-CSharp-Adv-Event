using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_Adv_Event.Youtube
{
    public class Subscriber
    {
        public string SubName { get; set; }




        public void Notify(Video video , Channel channel)
        {
            Console.WriteLine(value: $"{channel.ChannelName} Has Been Upload new video!, {SubName} \n {video}");
        }



        public override string ToString()
        {
            return $"Subscriber Name : {SubName}";
        }
    }
}
