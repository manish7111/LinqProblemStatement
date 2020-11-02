using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ProductReviewManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product review management problem statement");

            //UC-1
            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview(){ProductID=1,UserID=1,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductID=2,UserID=1,Rating=4,Review="Good",isLike=true},
                new ProductReview(){ProductID=3,UserID=2,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductID=4,UserID=2,Rating=4,Review="Good",isLike=true},
                new ProductReview(){ProductID=5,UserID=3,Rating=2,Review="nice",isLike=false},
                new ProductReview(){ProductID=6,UserID=4,Rating=1,Review="Bad",isLike=false},
                new ProductReview(){ProductID=1,UserID=3,Rating=1.5,Review="nice",isLike=false},
                new ProductReview(){ProductID=11,UserID=10,Rating=4,Review="nice",isLike=true},
                new ProductReview(){ProductID=10,UserID=10,Rating=4,Review="nice",isLike=true},
                new ProductReview(){ProductID=12,UserID=10,Rating=4,Review="nice",isLike=true},
                new ProductReview(){ProductID=13,UserID=10,Rating=4,Review="nice",isLike=true},
                new ProductReview(){ProductID=14,UserID=10,Rating=4,Review="nice",isLike=true},
                new ProductReview(){ProductID=15,UserID=10,Rating=4,Review="nice",isLike=true},
                new ProductReview(){ProductID=16,UserID=10,Rating=4,Review="nice",isLike=true}
            };
            //foreach(var list in productReviewList)
            //{
            //    Console.WriteLine("ProductID:-" + list.ProductID + " " + "UserID:-" + list.UserID 
            //        + " " + "Rating:-" + list.Rating + " " + "Review:-" + list.Review + " " + "isLike:-" + list.isLike);
            //}

            //UC-2
            Management management = new Management();
            //management.TopRecords(productReviewList);

            //UC-3
            // management.SelectedRecords(productReviewList);
            //UC-4
            //management.RetrieveCountOfRecords(productReviewList);
            //UC-5
            //management.RetrieveProductIdAndReview(productReviewList);
            //UC-6
            //management.SkipTopRecords(productReviewList);
            //UC-7
            List<ProductReview> ReviewList = new List<ProductReview>()
            {
                new ProductReview(){ProductID=10,UserID=1,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductID=20,UserID=1,Rating=4,Review="Good",isLike=true},
                new ProductReview(){ProductID=30,UserID=2,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductID=40,UserID=2,Rating=4,Review="Good",isLike=true},
                new ProductReview(){ProductID=50,UserID=3,Rating=2,Review="Not bad",isLike=false},
                new ProductReview(){ProductID=60,UserID=4,Rating=1,Review="Bad",isLike=false},
                new ProductReview(){ProductID=70,UserID=3,Rating=1.5,Review="Bad",isLike=false},
                new ProductReview(){ProductID=90,UserID=3,Rating=4,Review="Good",isLike=true},
                new ProductReview(){ProductID=90,UserID=3,Rating=4,Review="Good",isLike=true},
                new ProductReview(){ProductID=90,UserID=3,Rating=3.5,Review="nice",isLike=true}
            };
            var finalReviewList = productReviewList.Concat(ReviewList);
            //foreach (var list in finalReviewList)
            //{
            //    Console.WriteLine("ProductID:-" + list.ProductID + " " + "UserID:-" + list.UserID
            //        + " " + "Rating:-" + list.Rating + " " + "Review:-" + list.Review + " " + "isLike:-" + list.isLike);
            //}
            //UC-8,UC-9,UC-12
            management.ProductReviewsDataTable(productReviewList);
            //management.RetriveRecordsFromDataTable();
            //UC-10
            //management.AveragePerProductId(productReviewList);
            //UC-11
            //management.RetrieveRecordsUsingReview(productReviewList, "nice");
            //UC-12
            management.RetriveRecordsFromDataTableUsingUserID();
        }
    }
}
