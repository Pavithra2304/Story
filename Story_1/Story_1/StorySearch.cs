using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Story_1
{
    class StorySearch
    {
       
        
            public List<Story> findStory(List<Story> jobList, String authorname)
            {

                List<Story> result = new List<Story>();
                foreach (var item in jobList)
                {
                    if (item.Authorname.Equals(authorname))
                    {

                        result.Add(item);

                    }
                }

                return result;

            }
            public List<Story> findStory(List<Story> jobList, int noOfLikes)

            {
                List<Story> result = new List<Story>();
                foreach (var item in jobList)
                {
                    if (item.NoOfLikes >= noOfLikes)
                    {
                        result.Add(item);
                    }
                }
                return result;
            }

        
    }
}
