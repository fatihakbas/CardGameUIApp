using System;
using System.Text;
using System.Threading.Tasks;

namespace CardGameUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            PokerDeck pokerDeck = new PokerDeck();
            PlayPoker(pokerDeck);

            Console.WriteLine("---------------------------");

            BlackjackDeck blackjackDeck = new BlackjackDeck();
            PlayBlackjack(blackjackDeck);
            

            Console.ReadLine();
        }

        static void PlayPoker(PokerDeck deck)
        {
            var hand = deck.DealCards(); // Gives us our hand

            foreach (var card in hand)
            {
                Console.WriteLine($"{ card.Suit.ToString() } of { card.Value.ToString() }");
            }
        }

        static void PlayBlackjack(BlackjackDeck deck)
        {
            var hand = deck.DealCards(); // Gives us our hand

            foreach (var card in hand)
            {
                Console.WriteLine($"{ card.Suit.ToString() } of { card.Value.ToString() }");
            }
        }
    }
}
