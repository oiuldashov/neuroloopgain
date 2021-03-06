//
// NeuroLoopGain Library
// Library containing helper classes used to implement the NeuroLoopGain analysis.
//
// Copyright 2012 Marco Roessen
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.

using System;
using System.Runtime.Serialization;

namespace MchSlc.Library.Edf
{
  public class EdfException : ApplicationException
  {
    public EdfException()
    {
    }

    public EdfException(string message) : base(message)
    {
    }

    public EdfException(string message, Exception innerException) : base(message, innerException)
    {
    }

    protected EdfException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
  }
}