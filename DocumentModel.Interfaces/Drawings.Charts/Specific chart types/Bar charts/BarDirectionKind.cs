namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Bar Direction
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum BarDirectionKind
{
  /// <summary>
  ///   Bar.
  /// </summary>
  Bar,
  /// <summary>
  ///   IColumn.
  /// </summary>
  Column
}