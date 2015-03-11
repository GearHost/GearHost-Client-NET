using System;
using System.Collections.Generic;
using System.Linq;
/*
  -----------------------------------------------------------------------
  Dusty Hoppe (@HopDizzle)
  http://github.com/hopdizzle/gearhost-client-net
  ------------------------------------------------------------------------
  This file is part of gearhost-client-net.

  gearhost-client-net is free software: you can redistribute it and/or 
  modify it under the terms of the GNU General Public License as published 
  by the Free Software Foundation, either version 3 of the License, or
  (at your option) any later version.

  gearhost-client-net is distributed in the hope that it will be useful,
  but WITHOUT ANY WARRANTY; without even the implied warranty of
  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
  GNU General Public License for more details.

  You should have received a copy of the GNU General Public License
  along with Foobar.  If not, see <http://www.gnu.org/licenses/>.
  -----------------------------------------------------------------------
 */

namespace GearHost.Core.Entities
{
  public class Actions : List<Action>
  { }

  public class Action
  {
    public string id { get; set; }
    public string action { get; set; }
    public string ip { get; set; }
    public DateTime date { get; set; }
  }
}
