using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Wall
    {
		List<Figura> wallList;
        public Wall(int mapWight , int mapHight)
		{
			wallList = new List<Figura>();

			HorizontalLine horLineUp = new HorizontalLine(0, mapWight -2, 0, '+');
			HorizontalLine horLineDown = new HorizontalLine(0, mapWight -2, mapHight -2, '+');
			VerticalLine verticalLineLeft = new VerticalLine(0, 0, mapHight -2, '|');
			VerticalLine verticalLineRight = new VerticalLine(mapWight-2, 0, mapHight -2, '|');

			wallList.Add(horLineUp);
			wallList.Add(horLineDown);
			wallList.Add(verticalLineLeft);
			wallList.Add(verticalLineRight);

		}

		public void Draw()
		{
			foreach (var wall in wallList)
			{
				wall.Draw();
			}
		}
	 	internal bool IsHit(Figura figura)
		{
			foreach(var wall in wallList)
			{
				if(wall.IsHit(figura))
				{
					return true;
				}
				
			}
			return false;
		}

	}
}
