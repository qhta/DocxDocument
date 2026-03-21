namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a mathematical equation array object, consisting of one or more equations that can be vertically justified as a unit respect to surrounding text on the line.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omatheqarray?view=word-pia"/>
public interface OMathEqArray : InteropObject
{
  /// <summary>
  /// The e.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omatheqarray.e?view=word-pia"/>
  public OMathArgs E { get; }
  /// <summary>
  /// The max dist.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omatheqarray.maxdist?view=word-pia"/>
  public bool MaxDist { get; set; }
  /// <summary>
  /// The obj dist.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omatheqarray.objdist?view=word-pia"/>
  public bool ObjDist { get; set; }
  /// <summary>
  /// The align.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omatheqarray.align?view=word-pia"/>
  public WdOMathVertAlignType Align { get; set; }
  /// <summary>
  /// The row spacing rule.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omatheqarray.rowspacingrule?view=word-pia"/>
  public WdOMathSpacingRule RowSpacingRule { get; set; }
  /// <summary>
  /// The row spacing.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omatheqarray.rowspacing?view=word-pia"/>
  public int RowSpacing { get; set; }

}
