using System;

namespace UI
{
	public class Game
	{
		private static bool _IsStart;
		private static int _MaxScore;
		private static int _Score;

		public static bool Start(){
			return _IsStart = true;
		}

		public static bool Stop(){
			return _IsStart = false;
		}

		public static bool Started(){
			return _IsStart;
		}

		public static int SetMaxScore(int maxScore){
			return _MaxScore = maxScore;
		}

		public static int Reset(){
			return _Score = 0;
		}

		public static int GetScore(){
			return _Score;
		}

		public static int AddScore(){
			return _Score++;
		}

		public static bool CompleteGame(){
			return _Score == _MaxScore;
		}
	}
}

