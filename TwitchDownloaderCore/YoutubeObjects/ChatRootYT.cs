using System;
using System.Collections.Generic;
using System.Text;

public class ChatRootYT
{
    public Author author { get; set; }
    public String message { get; set; }
    public double time_in_seconds { get; set; }
    
}

public class Author
{
    public String name { get; set; }
    public List<Image> images { get; set; }
}

public class Image
{
    public string url;
}
