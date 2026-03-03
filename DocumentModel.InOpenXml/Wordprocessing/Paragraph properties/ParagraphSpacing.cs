namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the spacing settings between lines and paragraphs in a WordprocessingML document.
/// This class provides properties for configuring spacing above and below paragraphs, automatic spacing, line spacing, and line spacing rules, enabling advanced control over paragraph layout and readability.
/// </summary>
public partial class ParagraphSpacing: ModelElement<DXW.SpacingBetweenLines>
{
  /// <summary>
  /// Spacing above the paragraph.
  /// </summary>
  [OpenXmlLoadData(nameof(LoadBefore))]
  [OpenXmlUpdateData(nameof(UpdateBefore))]
  public SpacingBefore? Before { get => _Before; set => UpdateField(ref _Before, value, nameof(Before)); }

  private SpacingBefore? _Before;

  /// <summary>
  /// Spacing below the paragraph.
  /// </summary>
  [OpenXmlLoadData(nameof(LoadAfter))]
  [OpenXmlUpdateData(nameof(UpdateAfter))]
  public SpacingAfter? After { get => _After; set => UpdateField(ref _After, value, nameof(After)); }

  private SpacingAfter? _After;

  /// <summary>
  /// Spacing between lines within the paragraph.
  /// </summary>
  [OpenXmlLoadData(nameof(LoadInterlines))]
  [OpenXmlUpdateData(nameof(UpdateInterlines))]
  public SpacingInterlines? Interlines
  {
    get => _Interlines;
    set => UpdateField(ref _Interlines, value, nameof(Interlines));
  }

  private SpacingInterlines? _Interlines;

  /// <summary>
  /// Loads the spacing <see cref="Before"/> property from the provided source.
  /// </summary>
  /// <param name="source">The source configuration containing spacing values to apply.
  /// If <see langword="null"/>, no updates are performed.</param>
  public void LoadBefore(DXW.SpacingBetweenLines? source)
  {
    if (source == null) return;
    if (source.Before == null && source.BeforeLines == null && source.BeforeAutoSpacing == null) return;
    Before = new SpacingBefore();
    Before.Init(source.Before, source.BeforeLines, source.BeforeAutoSpacing);
  }

  /// <summary>
  /// Updates the spacing settings that precede the current paragraph based on the specified source configuration.
  /// </summary>
  /// <remarks>If the preceding spacing settings have not been initialized, this method creates them before
  /// applying the values from the source configuration. The method updates the spacing value, line count, and automatic
  /// spacing properties according to the provided source.</remarks>
  /// <param name="target">The source configuration containing spacing values to apply. If <see langword="null"/>, no updates are performed.</param>
  public void UpdateBefore(DXW.SpacingBetweenLines? target)
  {
    if (target == null || Before == null) return;

    if (Before.Val != null)
      target.Before = Before.Val.IntValue.ToString();
    if (Before.Lines != null)
      target.BeforeLines = Before.Lines.Value;
    if (Before.AutoSpacing != null)
      target.BeforeAutoSpacing = Before.AutoSpacing.Value;
  }

  /// <summary>
  /// Loads the spacing <see cref="After"/> property from the provided source.
  /// </summary>
  /// <param name="source">The source configuration containing spacing values to apply.
  /// If <see langword="null"/>, no updates are performed.</param>
  public void LoadAfter(DXW.SpacingBetweenLines? source)
  {
    if (source == null) return;
    if (source.After == null && source.AfterLines == null && source.AfterAutoSpacing == null) return;
    After = new SpacingAfter();
    After.Init(source.After, source.AfterLines, source.AfterAutoSpacing);
  }

  /// <summary>
  /// Updates the spacing settings that precede the current paragraph based on the specified source configuration.
  /// </summary>
  /// <remarks>If the preceding spacing settings have not been initialized, this method creates them before
  /// applying the values from the source configuration. The method updates the spacing value, line count, and automatic
  /// spacing properties according to the provided source.</remarks>
  /// <param name="target">The source configuration containing spacing values to apply. If <see langword="null"/>, no updates are performed.</param>
  public void UpdateAfter(DXW.SpacingBetweenLines? target)
  {
    if (target == null || After == null) return;

    if (After.Val != null)
      target.After = After.Val.IntValue.ToString();
    if (After.Lines != null)
      target.AfterLines = After.Lines.Value;
    if (After.AutoSpacing != null)
      target.AfterAutoSpacing = After.AutoSpacing.Value;
  }

  /// <summary>
  /// Loads interline spacing settings from the specified source object.
  /// </summary>
  /// <remarks>This method updates the Interlines property using values from the provided source. If the source
  /// is null, the method does not modify any settings.</remarks>
  /// <param name="source">The source object containing interline spacing information to apply. If null, no changes are made.</param>
  public void LoadInterlines(DXW.SpacingBetweenLines? source)
  {
    if (source == null) return;
    if (source.Line == null && source.LineRule == null) return;
    Interlines = new SpacingInterlines
    {
      Line = (source.Line?.Value) != null ? new Twips(source.Line.Value) : null,
      LineRule = source.LineRule?.GetEnumValue<DXW.LineSpacingRuleValues, LineSpacingRule>()
    };
  }

  /// <summary>
  /// Updates the specified spacing between lines object with the current interline settings, if available.
  /// </summary>
  /// <remarks>This method does not modify the target if either the target or the current interline settings are
  /// null.</remarks>
  /// <param name="target">The spacing between lines object to update. Must not be null.</param>
  public void UpdateInterlines(DXW.SpacingBetweenLines? target)
  {
    if (target == null || Interlines == null) return;

    if (Interlines.Line != null)
      target.Line = Interlines.Line.IntValue.ToString();
    if (Interlines.LineRule != null)
      target.LineRule = Interlines.LineRule.Value.CreateOpenXmlEnumValue<DXW.LineSpacingRuleValues, LineSpacingRule>();
  }
}