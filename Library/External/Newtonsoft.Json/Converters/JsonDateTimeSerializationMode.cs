/*
* sones GraphDB - Community Edition - http://www.sones.com
* Copyright (C) 2007-2011 sones GmbH
*
* This file is part of sones GraphDB Community Edition.
*
* sones GraphDB is free software: you can redistribute it and/or modify
* it under the terms of the GNU Affero General Public License as published by
* the Free Software Foundation, version 3 of the License.
* 
* sones GraphDB is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
* GNU Affero General Public License for more details.
*
* You should have received a copy of the GNU Affero General Public License
* along with sones GraphDB. If not, see <http://www.gnu.org/licenses/>.
* 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Newtonsoft.Json.Converters
{
  /// <summary>
  /// Specifies whether a DateTime object represents a local time, a Coordinated Universal Time (UTC), or is not specified as either local time or UTC.
  /// </summary>
  public enum JsonDateTimeSerializationMode
  {
    /// <summary>
    /// The time represented is local time.
    /// </summary>
    Local,
    /// <summary>
    /// The time represented is UTC.
    /// </summary>
    Utc,
    /// <summary>
    /// The time represented is not specified as either local time or Coordinated Universal Time (UTC).
    /// </summary>
    Unspecified,
    /// <summary>
    /// Preserves the DateTimeKind field of a date when a DateTime object is converted to a string and the string is then converted back to a DateTime object.
    /// </summary>
    RoundtripKind
  }
}