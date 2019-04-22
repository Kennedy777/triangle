using System;

namespace TriangeTracker
{
  public class Triangle
  {
    public int SideOne;
    public int SideTwo;
    public int SideThree;

    public  Triangle(int sideone,int sidetwo,int sidethree)
    {
      SideOne = sideOne;
      SideTwo = sidetwo;
      SideThree = sidethree;
    }


    public bool checkTri(int sideone,int sidetwo,int sidethree)
    {
      return  ((sideone + sidetwo<sidethree)|| (sideone + sidethree<sidetwo) || (sidetwo+sidethree < sideone));
    }
  }

}
