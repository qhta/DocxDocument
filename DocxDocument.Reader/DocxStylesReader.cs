using DocxDocument.Model;

using DM = DocxDocument.Model;
using WP = DocumentFormat.OpenXml.Wordprocessing;
using DR = DocumentFormat.OpenXml.Drawing;
using DMR = DocxDocument.Model.Drawing;

namespace DocxDocument.Reader;

public partial class DocxReader
{
  public DM.Styles ReadStyleDefinitions(WP.Styles? wpStyles)
  {
    var dmStyles = new DM.Styles();
    if (wpStyles == null)
      return dmStyles;

    var wpDocDefaults = wpStyles.DocDefaults;
    if (wpDocDefaults != null)
    {
      var wpRunPropertiesBaseStyle = wpDocDefaults.RunPropertiesDefault?.RunPropertiesBaseStyle;
      if (wpRunPropertiesBaseStyle != null)
        dmStyles.DefaultRunProperties = ReadRunProperties(wpRunPropertiesBaseStyle);
    }

    var wpLatentStyles = wpStyles.LatentStyles;
    if (wpLatentStyles != null)
      dmStyles.BuiltInStyles = ReadLatentStyles(wpLatentStyles);
    else
      dmStyles.BuiltInStyles = InitBuiltInStyles();
    dmStyles.InitIndexes();

    foreach (var wpStyle in wpStyles.Elements<WP.Style>())
    {
      if (wpStyle.CustomStyle?.Value == true)
        dmStyles.CustomStyles.Add(ReadCustomStyleDefinition(wpStyle));
      else
        ReadBuiltInStyleDefinition(dmStyles.BuiltInStyles, wpStyle);
    }

    return dmStyles;
  }

  private DM.BuiltInStyles ReadLatentStyles(WP.LatentStyles wpLatentStyles)
  {
    var dmBuiltInStyles = InitBuiltInStyles();
    dmBuiltInStyles.InitCount = wpLatentStyles.Count?.Value;
    dmBuiltInStyles.DefaultPrimaryStyle = wpLatentStyles.DefaultPrimaryStyle?.Value;
    dmBuiltInStyles.DefaultLockedState = wpLatentStyles.DefaultLockedState?.Value;
    dmBuiltInStyles.DefaultSemiHidden = wpLatentStyles.DefaultSemiHidden?.Value;
    dmBuiltInStyles.DefaultUnhideWhenUsed = wpLatentStyles.DefaultUnhideWhenUsed?.Value;
    dmBuiltInStyles.DefaultUiPriority = wpLatentStyles.DefaultUiPriority?.Value;
    if (dmBuiltInStyles.InitCount != null)
      for (int i = 0; i < dmBuiltInStyles.InitCount && i < dmBuiltInStyles.Count; i++)
      {
        var style = dmBuiltInStyles[i];
        if (dmBuiltInStyles.DefaultPrimaryStyle != null)
          style.PrimaryStyle = (bool)dmBuiltInStyles.DefaultPrimaryStyle;
        if (dmBuiltInStyles.DefaultLockedState != null)
          style.Locked = (bool)dmBuiltInStyles.DefaultLockedState;
        if (dmBuiltInStyles.DefaultSemiHidden != null)
          style.SemiHidden = (bool)dmBuiltInStyles.DefaultSemiHidden;
        if (dmBuiltInStyles.DefaultUnhideWhenUsed != null)
          style.UnhideWhenUsed = (bool)dmBuiltInStyles.DefaultUnhideWhenUsed;
        if (dmBuiltInStyles.DefaultUiPriority != null)
          style.UiPriority = (int)dmBuiltInStyles.DefaultUiPriority;
      }

    foreach (var wpLatentStyle in wpLatentStyles)
    {
      if (wpLatentStyle is WP.LatentStyleExceptionInfo wpLatentStyleExceptionInfo)
      {
        var styleName = wpLatentStyleExceptionInfo.Name;
        if (styleName != null)
        {
          var dmStyle = dmBuiltInStyles.FirstOrDefault(item =>
            item.OrigName.Equals(styleName, System.StringComparison.InvariantCultureIgnoreCase));
          if (dmStyle != null)
          {
            if (wpLatentStyleExceptionInfo.PrimaryStyle?.Value != null)
              dmStyle.PrimaryStyle = (bool)wpLatentStyleExceptionInfo.PrimaryStyle.Value;
            if (wpLatentStyleExceptionInfo.Locked?.Value != null)
              dmStyle.Locked = (bool)wpLatentStyleExceptionInfo.Locked.Value;
            if (wpLatentStyleExceptionInfo.SemiHidden?.Value != null)
              dmStyle.SemiHidden = (bool)wpLatentStyleExceptionInfo.SemiHidden.Value;
            if (wpLatentStyleExceptionInfo.UnhideWhenUsed?.Value != null)
              dmStyle.UnhideWhenUsed = (bool)wpLatentStyleExceptionInfo.UnhideWhenUsed.Value;
            if (wpLatentStyleExceptionInfo.UiPriority?.Value != null)
              dmStyle.UiPriority = (int)wpLatentStyleExceptionInfo.UiPriority.Value;
          }
          else
            throw new InvalidOperationException($"BuiltInStyle \"{styleName}\" not found");
        }
      }
    }

    return dmBuiltInStyles;
  }

  private DM.BuiltInStyles InitBuiltInStyles()
  {
    var dmBuiltInStyles = new DM.BuiltInStyles();
    foreach (var spec in PredefinedStyles.Mapping)
    {
      var style = new Style { Type = spec.Type, Name = spec.LocalName, OrigName = spec.OrigName };
      dmBuiltInStyles.Add(style);
    }

    return dmBuiltInStyles;
  }

  private DM.Style ReadCustomStyleDefinition (WP.Style wpStyle)
  {
    var dmStyle = new DM.Style();
    if (wpStyle.Type?.Value != null)
      dmStyle.Type = WpStyleType2DmStyleType(wpStyle.Type);
    dmStyle.Name = wpStyle.StyleName?.Val?.Value ?? string.Empty;

    return dmStyle;
  }

  private void ReadBuiltInStyleDefinition(DM.BuiltInStyles dmBuiltInStyles, WP.Style wpStyle)
  {
    var styleID = wpStyle.StyleId?.Value;
    if (styleID != null)
    {
      var builtInStyle =
        dmBuiltInStyles.FirstOrDefault(item => styleID.Equals(item.ID, StringComparison.InvariantCultureIgnoreCase));
      if (builtInStyle != null)
        ReadStyleDefinition(builtInStyle, wpStyle);
      //else
      //  throw new InvalidOperationException($"BuiltInStyle \"{styleID}\" not found.");
    }
  }

  private void ReadStyleDefinition(DM.Style dmStyle, WP.Style wpStyle)
  {
    if (wpStyle.Type?.Value != null)
      dmStyle.Type = WpStyleType2DmStyleType(wpStyle.Type);
    if (wpStyle.Default?.Value != null)
      dmStyle.Default = wpStyle.Default;
    var origName = wpStyle.StyleName?.Val?.Value;
    if (origName != null && !origName.Equals(dmStyle.OrigName, StringComparison.InvariantCultureIgnoreCase))
      dmStyle.OrigName = origName;
    var primaryStyle = wpStyle.PrimaryStyle!=null;
    if (primaryStyle)
      dmStyle.PrimaryStyle = primaryStyle;
    var wpRunProperties = wpStyle.StyleRunProperties;
    if (wpRunProperties!=null)
      dmStyle.RunProperties = ReadRunProperties(wpRunProperties);
  }

  private DM.StyleType WpStyleType2DmStyleType(WP.StyleValues wpStyleType)
  {
    switch (wpStyleType)
    {
      case WP.StyleValues.Paragraph:
        return DM.StyleType.Paragraph;
      case WP.StyleValues.Character:
        return DM.StyleType.Character;
      case WP.StyleValues.Table:
        return DM.StyleType.Table;
      case WP.StyleValues.Numbering:
        return DM.StyleType.List;
    }

    throw new InvalidOperationException($"Can't convert {wpStyleType} to StyleType");
  }
}