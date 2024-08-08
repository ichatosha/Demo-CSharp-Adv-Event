
using Demo_CSharp_Adv_Event.Youtube;


namespace demo_Event
{
    class Program
    {
        static void Main()
        {


            #region Ex 02 YOUTUBE

            Channel channel = new Channel() { ChannelName = " ABC" };
            // subscribers
            Subscriber sub01 = new Subscriber() { SubName = "hesham fathy" };
            Subscriber sub02 = new Subscriber() { SubName = "ahmed khalde" };
            Subscriber sub03 = new Subscriber() { SubName = "ali alii" };
            Subscriber sub04 = new Subscriber() { SubName = "mai ahmed" };
            Subscriber sub05 = new Subscriber() { SubName = "sara khalde" };
            Subscriber sub06 = new Subscriber() { SubName = "mohamed ali" };


            // add video
            // subscribe
            channel.UploadVideo += sub01.Notify;
            channel.UploadVideo += sub02.Notify;
            channel.UploadVideo += sub03.Notify;
            channel.UploadVideo += sub04.Notify;
            channel.UploadVideo += sub05.Notify;


            //channel.AddVideo(new Video() { Title = "Title 01" , Description = "desc01"} );

            //add video
            channel.AddVideo(new Video() { Title = "Title 02", Description = "desc02" });
            // unsubscribe
            channel.UploadVideo -= sub05.Notify;
            Console.WriteLine("after sara cancel the subscribtion!");
            //subscribe
            channel.UploadVideo += sub06.Notify;


            //add video
            channel.AddVideo(new Video() { Title = " Title 03", Description = "Desc 03" });





            #endregion


            #region Dict
            // can repeat value but cannot repeat the Key !

            Dictionary<string, long> Note = new Dictionary<string, long>();


            Note.Add("hesham", 12);
            //Note.Add("hesham", 001212); // Invalid
            Note.Add("ahemed", 33);
            Note.Add("ali", 16);
            Note.Add("hussam", 15);
            Note.Add("mahmoud", 1);

            



            foreach (var item in Note)
            {
                Console.WriteLine($"Key = {item.Key} , Value = {item.Value}");

            }

            #endregion

        }
    }
}