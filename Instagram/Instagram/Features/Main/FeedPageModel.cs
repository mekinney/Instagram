using FreshMvvm;
using Xamarin.Forms;
using System.Collections.Generic;

namespace Instagram
{


	public class Data
	{
		public string Name { get; set; }
		public string Image { get; set; }
		public string Comment { get; set; }
		public int CommentCount { get; set; }
		public string PostedAt { get; set; }
		public int ViewCount { get; set; }
	}


	public class FeedPageModel : FreshBasePageModel
    {


		public FeedPageModel()
		{
			// Example Data
			InstagramFeed = new List<Data>()
			{
				new Data()
				{
					ViewCount = 10517,
					Comment = "latenightseth Enjoy your well-deserved vacation, Mr President. #LNSM",
					CommentCount = 45,
					Image = "Burger.jpg",
					Name = "superfred",
					PostedAt = "1 hour ago"
				},

                new Data()
                {
                    ViewCount = 1,
                    Comment = "latenightseth Nubag alert. #LNSM",
                    CommentCount = 45,
                    Image = "Hawaii.jpg",
                    Name = "superfred",
                    PostedAt = "1 hour ago"
                },

                new Data()
                {
                    ViewCount = 1,
                    Comment = "magicmike Let it snow, let it snow, let it snow. #SNOW",
                    CommentCount = 4,
                    Image = "SnowTruck.jpg",
                    Name = "magicmike",
                    PostedAt = "2 hours ago"
                }


            };

		}

		public List<Data> InstagramFeed { get; set; }

	}
}
