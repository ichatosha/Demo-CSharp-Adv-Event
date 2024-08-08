using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_Adv_Event.Youtube
{
    public class Channel
    {
        public string? ChannelName { get; set; }
        public List<Video>? Videos { get; set; }



        public void AddVideo(Video video)
        {
            Videos?.Add(video);
            // notify subscriber : create action event and invoke
            UploadVideo?.Invoke(video , this);

        }


        // action event
        public event Action<Video , Channel>? UploadVideo;


        public override string ToString()
        {
            return $"Channel Name : {ChannelName}";
        }
    }
}
