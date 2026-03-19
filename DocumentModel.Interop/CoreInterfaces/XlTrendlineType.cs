using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[TypeLibType(16)]
public enum XlTrendlineType
{
  xlExponential = 5,
  xlLinear = -4132,
  xlLogarithmic = -4133,
  xlMovingAvg = 6,
  xlPolynomial = 3,
  xlPower = 4
}