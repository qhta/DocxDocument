namespace DocumentModel.Drawings;

/// <summary>
///   Represents an English Metric Unit (EMU), used for precise measurements in drawings.
///   There are 12700 EMUs per inch.
/// </summary>
public interface EMU : IComparable<EMU>, IEquatable<EMU>
{
  /// <summary>
  ///   Numeric value of the EMU.
  /// </summary>
  public long Value { get; set; }
}