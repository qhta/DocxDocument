using DocumentFormat.OpenXml;

namespace DocxDocument.Model;

public enum BreakBinaryOperator
{
  /// <summary>
  /// Before.
  /// </summary>
  [EnumString("before")]
  Before,
  /// <summary>
  /// After.
  /// </summary>
  [EnumString("after")]
  After,
  /// <summary>
  /// Repeat.
  /// </summary>
  [EnumString("repeat")]
  Repeat
}
