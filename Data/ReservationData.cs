using System;
using escapeRoom.Models;

namespace escapeRoom.Data
{
	public class ReservationData
	{
		public List<Group> Queue = new List<Group>();
		public List<Group> NewReservationList = new List<Group>();
        private int people;

        public void CompareSizes(List<Group> reservations)
		{
			foreach(Group reservation in reservations)
			{
				if(people < 7)
				{
                    if (reservation.GroupSize > 0 && reservation.GroupSize < 7)
                    {
                        Queue.Add(reservation);
                        people += reservation.GroupSize;
					}
					else
					{
						return;
					}
				}
				else
				{
					return;
				}

			}
		}

	}
}

