using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LINQProduct
{
    class Management
    {
        public readonly DataTable dataTable = new DataTable();
        /// <summary>
        /// UC 2 Display top 3 record
        /// </summary>
        /// <param name="review"></param>
        public void TopRecords(List<ProductReview> listProductReview)
        {
            var recordData = (from productReviews in listProductReview 
                              orderby productReviews.Rating descending 
                              select productReviews).Take(3);
            foreach(var list in recordData)
            {
                Console.WriteLine("ProductID : " + list.ProductID + " UserID : " + list.UserID + " Rating : " + list.Rating
                    + " Review : " + list.Review + " isLike : " + list.isLike);
            }
        }
        /// <summary>
        /// UC3 Retrive record who's rating is greater than 3 and product id is 3,4,9
        /// </summary>
        /// <param name="listProductReview"></param>
        public void SelectedRecord(List<ProductReview> listProductReview)
        {
            var recordData = from ProductReview in listProductReview
                             where (ProductReview.ProductID == 1 || ProductReview.ProductID == 4 || ProductReview.ProductID == 9) && ProductReview.Rating > 3
                             select ProductReview;
            foreach (var list in recordData)
            {
                Console.WriteLine("ProductID : " + list.ProductID + " UserID : " + list.UserID + " Rating : " + list.Rating
                    + " Review : " + list.Review + " isLike : " + list.isLike);
            }
        }
        /// <summary>
        /// UC 4 Retrieve count of product id
        /// </summary>
        /// <param name="listProductReview"></param>
        public void RetrieveCountOfRecords(List<ProductReview> listProductReview)
        {
            var recordCount = listProductReview.GroupBy(x => x.ProductID)
                .Select(x => new { ProductID = x.Key, Count = x.Count() });
            foreach( var list in recordCount)
            {
                Console.WriteLine("Product id : " + list.ProductID + " Count " + list.Count);
            }
        }
        /// <summary>
        /// UC 5 Retrieve product id and review
        /// </summary>
        /// <param name="listProductReview"></param>
        public void RetrieveProductIdAndReview(List<ProductReview> listProductReview)
        {
            var recordPidReview = from product in listProductReview select (product.ProductID, product.Review);
            foreach (var list in recordPidReview)
            {
                Console.WriteLine("Product id : " + list.ProductID + " Review : " + list.Review);
            }
        }
        /// <summary>
        /// UC 6 skip 5 records
        /// </summary>
        /// <param name="listProductReview"></param>
        public void SkipFiveRecord(List<ProductReview> listProductReview)
        {
            var records = (from product in listProductReview select product).Skip(5);
            foreach (var list in records)
            {
                Console.WriteLine("ProductID : " + list.ProductID + " UserID : " + list.UserID + " Rating : " + list.Rating
                    + " Review : " + list.Review + " isLike : " + list.isLike);
            }
        }

    }
}
