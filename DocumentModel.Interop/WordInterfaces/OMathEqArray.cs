namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a mathematical equation array object, consisting of one or more equations that can be vertically justified as a unit respect to surrounding text on the line.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omatheqarray?view=word-pia"/>
public interface OMathEqArray : InteropObject
{
  /// <summary>
  /// Returns the e.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omatheqarray.e?view=word-pia"/>
  public OMathArgs E { get; }
  /// <summary>
  /// Returns or sets whether max dist.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omatheqarray.maxdist?view=word-pia"/>
  public bool MaxDist { get; set; }
  /// <summary>
  /// Returns or sets whether obj dist.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omatheqarray.objdist?view=word-pia"/>
  public bool ObjDist { get; set; }
  /// <summary>
  /// Returns or sets the align.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omatheqarray.align?view=word-pia"/>
  public WdOMathVertAlignType Align { get; set; }
  /// <summary>
  /// Returns or sets the row spacing rule.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omatheqarray.rowspacingrule?view=word-pia"/>
  public WdOMathSpacingRule RowSpacingRule { get; set; }
  /// <summary>
  /// Returns or sets the row spacing.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omatheqarray.rowspacing?view=word-pia"/>
  public int RowSpacing { get; set; }

}
