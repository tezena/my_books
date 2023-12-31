﻿namespace My_books.Data.VmModels
{
    public class BookVM
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public string Genre { get; set; }
        public bool IsRead { get; set; }
        public DateTime? ReadDate { get; set; }
        public int? Rate { get; set; }
        public string CoverUrl { get; set; }

        public Guid PublisherId { get; set; }

        public List<Guid> AuthorsId { get; set; }
    }


    public class BookGetVM
    {   
        public Guid id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public string Genre { get; set; }
        public bool IsRead { get; set; }
        public DateTime? ReadDate { get; set; }
        public int? Rate { get; set; }
        public string CoverUrl { get; set; }

        public string PublisherName { get; set; }

        public List<string> AuthorsName { get; set; }
    }


}
