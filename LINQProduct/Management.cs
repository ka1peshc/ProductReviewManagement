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


    }
}
