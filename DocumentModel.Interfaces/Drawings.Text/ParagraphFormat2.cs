
using DocumentModel.Wordprocessing;

namespace DocumentModel.Drawings.Text;

/// <summary>
/// Represents paragraph formatting of a text range.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2?view=office-pia"/>
public partial interface IParagraphFormat2 : IModelObject
{
  /// <summary>
  /// Gets or sets the `Alignment` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.alignment?view=office-pia"/>
  public ParagraphAlignment Alignment { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `BaselineAlignment` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.baselinealignment?view=office-pia"/>
  public BaselineAlignment BaselineAlignment { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets the `Bullet` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.bullet?view=office-pia"/>
  public IBulletFormat Bullet { get; }
  /// <summary>
  /// Gets or sets the `FarEastLineBreakLevel` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.fareastlinebreaklevel?view=office-pia"/>
  public TriState FarEastLineBreakLevel { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `FirstLineIndent` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.firstlineindent?view=office-pia"/>
  public float FirstLineIndent { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `HangingPunctuation` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.hangingpunctuation?view=office-pia"/>
  public TriState HangingPunctuation { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `IndentLevel` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.indentlevel?view=office-pia"/>
  public int IndentLevel { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `LeftIndent` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.leftindent?view=office-pia"/>
  public float LeftIndent { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `LineRuleAfter` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.lineruleafter?view=office-pia"/>
  public TriState LineRuleAfter { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `LineRuleBefore` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.linerulebefore?view=office-pia"/>
  public TriState LineRuleBefore { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `LineRuleWithin` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.linerulewithin?view=office-pia"/>
  public TriState LineRuleWithin { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `RightIndent` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.rightindent?view=office-pia"/>
  public float RightIndent { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `SpaceAfter` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.spaceafter?view=office-pia"/>
  public float SpaceAfter { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `SpaceBefore` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.spacebefore?view=office-pia"/>
  public float SpaceBefore { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `SpaceWithin` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.spacewithin?view=office-pia"/>
  public float SpaceWithin { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets the `TabStops` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.tabstops?view=office-pia"/>
  public ITabStops TabStops { get; }
  /// <summary>
  /// Gets or sets the `TextDirection` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.textdirection?view=office-pia"/>
  public TextDirection TextDirection { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `WordWrap` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.paragraphformat2.wordwrap?view=office-pia"/>
  public TriState WordWrap { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}

