using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Chap10CardLib;

namespace InterviewPractice.Controllers
{
    public class GameController : ApiController
    {
        Deck myDeck = new Deck();

        public IEnumerable<Card> Get()
        {
            IList<Card> cardList = new List<Card>();

            cardList.Add(new Card(Suit.Club, Rank.Ace));
            cardList.Add(new Card(Suit.Diamond, Rank.Ace));
            cardList.Add(new Card(Suit.Heart, Rank.Ace));
            cardList.Add(new Card(Suit.Spade, Rank.Ace));

            return cardList;
        }

        public HttpResponseMessage  Post([FromBody] string values)
        {
            try
            {

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                HttpError myCustomError = new HttpError("The file has no content or rows to process.") { { "CustomErrorCode", 42 } };
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, myCustomError);
            }

            return Request.CreateResponse(HttpStatusCode.OK, "Card Request was successfully processed.");

        }

        [HttpPost]
        public HttpResponseMessage ShuffleCards([FromBody] string values)
        {
            //bool.Parse()
            //Char.Parse()
            // Boolean.Parse()
            //Int32.Parse()
            myDeck.Shuffle();

            return Request.CreateResponse(HttpStatusCode.OK, GetDeck());
        }

        private String GetDeck()
        {
            var builder = new StringBuilder(500);
            for (int i = 0; i < 52; i++)
            {
                Card temnpCard = myDeck.GetCard(i);
                builder.AppendLine(temnpCard.ToString());
            }

            return builder.ToString();
        }

    }
}
