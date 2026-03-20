
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `ParagraphFormat2` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2?view=office-pia` for Office interop details.
/// </remarks>
public partial interface ParagraphFormat2: InteropObject
{
  /// <summary>
  /// Gets or sets the `Alignment` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.alignment?view=office-pia
  /// </remarks>
  public MsoParagraphAlignment Alignment { get; set; }
  /// <summary>
  /// Gets or sets the `BaselineAlignment` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.baselinealignment?view=office-pia
  /// </remarks>
  public MsoBaselineAlignment BaselineAlignment { get; set; }
  /// <summary>
  /// Gets the `Bullet` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.bullet?view=office-pia
  /// </remarks>
  public BulletFormat2 Bullet { get; }
  /// <summary>
  /// Gets or sets the `FarEastLineBreakLevel` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.fareastlinebreaklevel?view=office-pia
  /// </remarks>
  public MsoTriState FarEastLineBreakLevel { get; set; }
  /// <summary>
  /// Gets or sets the `FirstLineIndent` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.firstlineindent?view=office-pia
  /// </remarks>
  public float FirstLineIndent { get; set; }
  /// <summary>
  /// Gets or sets the `HangingPunctuation` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.hangingpunctuation?view=office-pia
  /// </remarks>
  public MsoTriState HangingPunctuation { get; set; }
  /// <summary>
  /// Gets or sets the `IndentLevel` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.indentlevel?view=office-pia
  /// </remarks>
  public int IndentLevel { get; set; }
  /// <summary>
  /// Gets or sets the `LeftIndent` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.leftindent?view=office-pia
  /// </remarks>
  public float LeftIndent { get; set; }
  /// <summary>
  /// Gets or sets the `LineRuleAfter` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.lineruleafter?view=office-pia
  /// </remarks>
  public MsoTriState LineRuleAfter { get; set; }
  /// <summary>
  /// Gets or sets the `LineRuleBefore` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.linerulebefore?view=office-pia
  /// </remarks>
  public MsoTriState LineRuleBefore { get; set; }
  /// <summary>
  /// Gets or sets the `LineRuleWithin` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.linerulewithin?view=office-pia
  /// </remarks>
  public MsoTriState LineRuleWithin { get; set; }
  /// <summary>
  /// Gets or sets the `RightIndent` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.rightindent?view=office-pia
  /// </remarks>
  public float RightIndent { get; set; }
  /// <summary>
  /// Gets or sets the `SpaceAfter` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.spaceafter?view=office-pia
  /// </remarks>
  public float SpaceAfter { get; set; }
  /// <summary>
  /// Gets or sets the `SpaceBefore` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.spacebefore?view=office-pia
  /// </remarks>
  public float SpaceBefore { get; set; }
  /// <summary>
  /// Gets or sets the `SpaceWithin` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.spacewithin?view=office-pia
  /// </remarks>
  public float SpaceWithin { get; set; }
  /// <summary>
  /// Gets the `TabStops` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.tabstops?view=office-pia
  /// </remarks>
  public TabStops2 TabStops { get; }
  /// <summary>
  /// Gets or sets the `TextDirection` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.textdirection?view=office-pia
  /// </remarks>
  public MsoTextDirection TextDirection { get; set; }
  /// <summary>
  /// Gets or sets the `WordWrap` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.wordwrap?view=office-pia
  /// </remarks>
  public MsoTriState WordWrap { get; set; }
}
