namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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
  IColumn
}
