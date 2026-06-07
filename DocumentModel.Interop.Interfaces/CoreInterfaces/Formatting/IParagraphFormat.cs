
namespace DocumentModel.Interop.Core;	
/// <summary>
/// Represents paragraph formatting of a text range.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2?view=office-pia"/>
public interface IParagraphFormat: IInteropObject
{
  /// <summary>
  /// Gets or sets the `Alignment` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.alignment?view=office-pia"/>
  public ParagraphAlignment Alignment { get; set; }
  /// <summary>
  /// Gets or sets the `BaselineAlignment` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.baselinealignment?view=office-pia"/>
  public BaselineAlignment BaselineAlignment { get; set; }
  /// <summary>
  /// Gets the `Bullet` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.bullet?view=office-pia"/>
  public IBulletFormat Bullet { get; }
  /// <summary>
  /// Gets or sets the `FarEastLineBreakLevel` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.fareastlinebreaklevel?view=office-pia"/>
  public TriState FarEastLineBreakLevel { get; set; }
  /// <summary>
  /// Gets or sets the `FirstLineIndent` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.firstlineindent?view=office-pia"/>
  public float FirstLineIndent { get; set; }
  /// <summary>
  /// Gets or sets the `HangingPunctuation` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.hangingpunctuation?view=office-pia"/>
  public TriState HangingPunctuation { get; set; }
  /// <summary>
  /// Gets or sets the `IndentLevel` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.indentlevel?view=office-pia"/>
  public int IndentLevel { get; set; }
  /// <summary>
  /// Gets or sets the `LeftIndent` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.leftindent?view=office-pia"/>
  public float LeftIndent { get; set; }
  /// <summary>
  /// Gets or sets the `LineRuleAfter` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.lineruleafter?view=office-pia"/>
  public TriState LineRuleAfter { get; set; }
  /// <summary>
  /// Gets or sets the `LineRuleBefore` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.linerulebefore?view=office-pia"/>
  public TriState LineRuleBefore { get; set; }
  /// <summary>
  /// Gets or sets the `LineRuleWithin` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.linerulewithin?view=office-pia"/>
  public TriState LineRuleWithin { get; set; }
  /// <summary>
  /// Gets or sets the `RightIndent` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.rightindent?view=office-pia"/>
  public float RightIndent { get; set; }
  /// <summary>
  /// Gets or sets the `SpaceAfter` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.spaceafter?view=office-pia"/>
  public float SpaceAfter { get; set; }
  /// <summary>
  /// Gets or sets the `SpaceBefore` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.spacebefore?view=office-pia"/>
  public float SpaceBefore { get; set; }
  /// <summary>
  /// Gets or sets the `SpaceWithin` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.spacewithin?view=office-pia"/>
  public float SpaceWithin { get; set; }
  /// <summary>
  /// Gets the `TabStops` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.tabstops?view=office-pia"/>
  public ITabStops TabStops { get; }
  /// <summary>
  /// Gets or sets the `TextDirection` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.textdirection?view=office-pia"/>
  public TextDirection TextDirection { get; set; }
  /// <summary>
  /// Gets or sets the `WordWrap` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.wordwrap?view=office-pia"/>
  public TriState WordWrap { get; set; }
}	
