using System;
using System.Collections.Generic;

namespace LINQProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product review management problem");
            //UC 1 
            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview() { ProductID =1, UserID =1, Rating =2, Review = "good", isLike = true},
                new ProductReview() { ProductID =2, UserID =1, Rating =4, Review = "good", isLike = true},
                new ProductReview() { ProductID =3, UserID =2, Rating =5, Review = "good", isLike = true},
                new ProductReview() { ProductID =4, UserID =2, Rating =6, Review = "good", isLike = true},
                new ProductReview() { ProductID =5, UserID =3, Rating =2, Review = "nice", isLike = false},
                new ProductReview() { ProductID =6, UserID =4, Rating =1, Review = "Bad", isLike = false},
                new ProductReview() { ProductID =7, UserID =3, Rating =1.5, Review = "nice", isLike = false},
                new ProductReview() { ProductID =8, UserID =3, Rating =1.5, Review = "nice", isLike = false},
                new ProductReview() { ProductID =9, UserID =3, Rating =3.5, Review = "nice", isLike = false},
                new ProductReview() { ProductID =11, UserID =10, Rating =9, Review = "nice", isLike = true},
                new ProductReview() { ProductID =10, UserID =10, Rating =4, Review = "nice", isLike = true},
                new ProductReview() { ProductID =12, UserID =10, Rating =4, Review = "nice", isLike = true},
                new ProductReview() { ProductID =13, UserID =10, Rating =4, Review = "nice", isLike = true},
                new ProductReview() { ProductID =14, UserID =10, Rating =4, Review = "nice", isLike = true},
                new ProductReview() { ProductID =15, UserID =10, Rating =4, Review = "nice", isLike = true},
                new ProductReview() { ProductID =16, UserID =10, Rating =4, Review = "nice", isLike = true}
            };

            //foreach( var list in productReviewList)
            //{
            //    Console.WriteLine("ProductID : " + list.ProductID + " UserID : " + list.UserID + " Rating : " + list.Rating
            //        + " Review : " + list.Review + " isLike : " + list.isLike);
            //}

            Management management = new Management();
            //UC 2
            //management.TopRecords(productReviewList);

            //UC 3
            management.SelectedRecord(productReviewList);
        }
    }
}
