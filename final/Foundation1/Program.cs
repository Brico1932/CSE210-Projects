using System;

class Program
{
    static void Main(string[] args)
    {
        Comment comment1 = new Comment("Dadbod14","This is totally sick dude.");
        Comment comment2 = new Comment("High5-99","This is the funniest thing I've ever seen!");
        Comment comment3 = new Comment("Brody-Rocks88","#adorable");
        Comment comment4 = new Comment("Lot-a-love90","That has got to hurt!!!");
        Comment comment5 = new Comment("Dreamer55","#superfunny");
        Comment comment6 = new Comment("Believer122","That was amazing!");
        Comment comment7 = new Comment("Fire-man790","What in the world did I just see?");
        Comment comment8 = new Comment("YankeDoodles","Love that guy!");
        Comment comment9 = new Comment("cuatro4cuatro","Que en el mundo? jajajaja");
        Comment comment10 = new Comment("WildWeirdo","Cats rule dogs drool");

        List<Comment> vid1comments = new List<Comment>(){comment10, comment2, comment3};
        List<Comment> vid2comments = new List<Comment>(){comment4, comment5, comment6, comment8};
        List<Comment> vid3comments = new List<Comment>(){comment7, comment8, comment9};
        List<Comment> vid4comments = new List<Comment>(){comment1, comment4, comment9, comment6, comment2};
        Video vid1 = new Video("Cat fights dog", "Artyboi", 60,vid1comments);
        Video vid2 = new Video("Baby farts bubbles", "Typhlosion", 32,vid2comments);
        Video vid3 = new Video("Old man laughing", "G-matoot", 75,vid3comments);
        Video vid4 = new Video("Epic snowboarding fail", "Nightbright13", 120,vid4comments);
        List<Video> allvideos = new List<Video>(){vid1,vid2,vid3,vid4};

        foreach (Video vid in allvideos)
        {
            Console.WriteLine();
            int num_comments = vid.CountComments(vid);
            vid.DisplayVidInfo(vid,num_comments);
            int counter = 0;
            foreach (Comment comment in vid.GetComments())
            {
                counter++;
                Console.WriteLine($"+ Comment {counter}");
                comment.DisplayComment();
            }
        }
    }
}