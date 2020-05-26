using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaRazorPage.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReference1;

namespace MediaRazorPage.Pages.Photos
{
    public class IndexModel : PageModel
    {
        MediaClient mc = new MediaClient();
        public List<RazorPhotos> Items { get; set; }
         public List<RazorTagsTags> Tags { get; set; }
        public IndexModel()
        {
            Items = new List<RazorPhotos>();
            Tags = new List<RazorTagsTags>();
        }


        public async Task OnGetAsync(string name, string tag, string photoIdTag)
        {
            if(photoIdTag != null)
            {
                var number = Int32.Parse(photoIdTag);
                //var searchedTags = await mc.(number);
                var searchedTags = await mc.SearchTagByPhotoIdAsync(number);
                foreach (var item in searchedTags)
                {
                    RazorTagsTags it = new RazorTagsTags();
                    it.Id = item.Id;
                    it.Name = item.Name;
                    it.PhotoId = item.PhotoId;

                    Tags.Add(it);
                }


                var items2 = await mc.GetPhotosAsync();

                foreach (var item in items2)
                {
                    RazorPhotos it = new RazorPhotos();
                    it.Id = item.Id;
                    it.Name = item.Name;
                    it.Event = item.Event;
                    it.Url = item.Url;

                    Items.Add(it);
                }
                return;

            }
            if (name != null)
            {
                var searchedItems = await mc.SearchPhotoByNameAsync(name);
                foreach (var item in searchedItems)
                {
                    RazorPhotos it = new RazorPhotos();
                    it.Id = item.Id;
                    it.Name = item.Name;
                    it.Event = item.Event;
                    it.Url = item.Url;

                    Items.Add(it);
                }
                return;
            }

            if (tag != null)
            {
                var searchedItems = await mc.SearchPhotoByTagAsync(tag);
                foreach (var item in searchedItems)
                {
                    RazorPhotos it = new RazorPhotos();
                    it.Id = item.Id;
                    it.Name = item.Name;
                    it.Event = item.Event;
                    it.Url = item.Url;

                    Items.Add(it);
                }
                return;
            }

            var items = await mc.GetPhotosAsync();

            foreach (var item in items)
            {
                RazorPhotos it = new RazorPhotos();
                it.Id = item.Id;
                it.Name = item.Name;
                it.Event = item.Event;
                it.Url = item.Url;

                Items.Add(it);
            }
        }


    }
}