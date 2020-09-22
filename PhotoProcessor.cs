using System;

namespace ultimate_csharp_mastery
{

    public class PhotoProcessor
    {
        // Action<> void
        // Func<> returns value

        public void Process(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);

            filterHandler(photo);

            photo.Save();
        }
    }
}