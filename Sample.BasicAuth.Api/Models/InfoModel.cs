using System;
namespace Sample.BasicAuth.Api.Models
{
    public class InfoModel
    {
        public InfoModel()
        {
            Id = Guid.NewGuid().ToString();
            DateTime = System.DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
            DayOfWeek = Enum.GetName(typeof(DayOfWeek), System.DateTime.UtcNow.DayOfWeek);
        }

        public String Id { get; set; }
        public String DateTime { get; set; }
        public String DayOfWeek { get; set; }
    }
}
