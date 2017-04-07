﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TexasHoldem.Logic.User;

namespace TexasHoldem.Logic.Actions
{
    public abstract class Action
    {

        private Player _player;
        private int _gameID;
        private int _gameNumber;

        public Player Player { get => _player; set => _player = value; }
        public int GameID { get => _gameID; set => _gameID = value; }
        public int GameNumber { get => _gameNumber; set => _gameNumber = value; }

        public abstract void DoAction();

    }
}