﻿using CardsAgainstHumanityLibrary.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsAgainstHumanityLibrary
{
	public sealed class RoundPlay
	{
		private readonly WhiteCard[] _whiteCards;

		public BlackCard PromptCard { get; }

		public Player Player { get; }

		public bool Winning { get; internal set; }

		public IEnumerable<WhiteCard> GetCards()
		{
			foreach (var card in _whiteCards) yield return card;
		}

		internal RoundPlay(Player player, IEnumerable<WhiteCard> whiteCards, BlackCard prompt)
		{
			Player = player;
			_whiteCards = whiteCards.ToArray();
			PromptCard = prompt;
		}
	}
}
