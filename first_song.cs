/*---------------------------------------------------------------------------+
 |
 |  $Source: Song.cs $
 |
 |  $Copyright: (c) 2017 Bentley Systems, Incorporated. All rights reserved. $
 |              
 |
 +---------------------------------------------------------------------------*/
class Song
    {
    var it = new object[] { her, sadSong };
    object GetObject ()
        {
        it[Random.Next(it.Count)];
        }

    void play ()
        {
        #region Don't make it bad
        self.MakeItBetter (it[1]);
        if (self.hearth.LetInto(it[0]))
            self.MakeItBetter(GetObject ());
        #endregion

        #region Don't be afraid
        //TODO: go out and get
        if (self.skin.LetUnder(it[0]))
            self.MakeItBetter(GetObject ());
        #endregion

        #region Don't let me down
        while (self.Find (GetObject ()) == true)
            {
            //TODO: go out and get
            if (self.hearth.LetInto(it[0]))
                self.MakeItBetter(GetObject ());
            }
        #endregion

        //std::out & std::in & begin

        #region Don't make it bad
        self.MakeItBetter( self.get(it[1]) );
        if (self.skin.LetUnder(it[0]))
            {
            while (self.MakeItBetter (GetObject ()))
                {
                WriteLine("Better");
                }
            }
        #endregion

        #region Outro
        for (;;) { WriteLine ("na"); }
        #endregion
        }
    }
    