namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the SdtContentRunRuby Class.
/// </summary>
public static class SdtContentRunRubyConverter
{
  private static DMW.CustomXmlRuby? GetCustomXmlRuby(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXW.CustomXmlRubyConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlRuby>());
  }
  
  private static bool CmpCustomXmlRuby(DXW.SdtContentRunRuby openXmlElement, DMW.CustomXmlRuby? value, DiffList? diffs, string? objName)
  {
    return DMXW.CustomXmlRubyConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlRuby>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlRuby(DXW.SdtContentRunRuby openXmlElement, DMW.CustomXmlRuby? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CustomXmlRuby>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.CustomXmlRubyConverter.CreateOpenXmlElement<DXW.CustomXmlRuby>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.SimpleFieldRuby? GetSimpleFieldRuby(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXW.SimpleFieldRubyConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.SimpleFieldRuby>());
  }
  
  private static bool CmpSimpleFieldRuby(DXW.SdtContentRunRuby openXmlElement, DMW.SimpleFieldRuby? value, DiffList? diffs, string? objName)
  {
    return DMXW.SimpleFieldRubyConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.SimpleFieldRuby>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSimpleFieldRuby(DXW.SdtContentRunRuby openXmlElement, DMW.SimpleFieldRuby? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SimpleFieldRuby>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.SimpleFieldRubyConverter.CreateOpenXmlElement<DXW.SimpleFieldRuby>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.HyperlinkRuby? GetHyperlinkRuby(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXW.HyperlinkRubyConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.HyperlinkRuby>());
  }
  
  private static bool CmpHyperlinkRuby(DXW.SdtContentRunRuby openXmlElement, DMW.HyperlinkRuby? value, DiffList? diffs, string? objName)
  {
    return DMXW.HyperlinkRubyConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.HyperlinkRuby>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetHyperlinkRuby(DXW.SdtContentRunRuby openXmlElement, DMW.HyperlinkRuby? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.HyperlinkRuby>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.HyperlinkRubyConverter.CreateOpenXmlElement<DXW.HyperlinkRuby>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.Run? GetRun(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXW.RunConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.Run>());
  }
  
  private static bool CmpRun(DXW.SdtContentRunRuby openXmlElement, DMW.Run? value, DiffList? diffs, string? objName)
  {
    return DMXW.RunConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.Run>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRun(DXW.SdtContentRunRuby openXmlElement, DMW.Run? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Run>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RunConverter.CreateOpenXmlElement<DXW.Run>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.SdtRunRuby? GetSdtRunRuby(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXW.SdtRunRubyConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.SdtRunRuby>());
  }
  
  private static bool CmpSdtRunRuby(DXW.SdtContentRunRuby openXmlElement, DMW.SdtRunRuby? value, DiffList? diffs, string? objName)
  {
    return DMXW.SdtRunRubyConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.SdtRunRuby>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSdtRunRuby(DXW.SdtContentRunRuby openXmlElement, DMW.SdtRunRuby? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SdtRunRuby>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.SdtRunRubyConverter.CreateOpenXmlElement<DXW.SdtRunRuby>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.ProofError? GetProofError(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXW.ProofErrorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.ProofError>());
  }
  
  private static bool CmpProofError(DXW.SdtContentRunRuby openXmlElement, DMW.ProofError? value, DiffList? diffs, string? objName)
  {
    return DMXW.ProofErrorConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.ProofError>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetProofError(DXW.SdtContentRunRuby openXmlElement, DMW.ProofError? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ProofError>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ProofErrorConverter.CreateOpenXmlElement<DXW.ProofError>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.PermStart? GetPermStart(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXW.PermStartConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.PermStart>());
  }
  
  private static bool CmpPermStart(DXW.SdtContentRunRuby openXmlElement, DMW.PermStart? value, DiffList? diffs, string? objName)
  {
    return DMXW.PermStartConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.PermStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPermStart(DXW.SdtContentRunRuby openXmlElement, DMW.PermStart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PermStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.PermStartConverter.CreateOpenXmlElement<DXW.PermStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.PermEnd? GetPermEnd(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXW.PermEndConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.PermEnd>());
  }
  
  private static bool CmpPermEnd(DXW.SdtContentRunRuby openXmlElement, DMW.PermEnd? value, DiffList? diffs, string? objName)
  {
    return DMXW.PermEndConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.PermEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPermEnd(DXW.SdtContentRunRuby openXmlElement, DMW.PermEnd? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PermEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.PermEndConverter.CreateOpenXmlElement<DXW.PermEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.BookmarkStart? GetBookmarkStart(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXW.BookmarkStartConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.BookmarkStart>());
  }
  
  private static bool CmpBookmarkStart(DXW.SdtContentRunRuby openXmlElement, DMW.BookmarkStart? value, DiffList? diffs, string? objName)
  {
    return DMXW.BookmarkStartConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.BookmarkStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBookmarkStart(DXW.SdtContentRunRuby openXmlElement, DMW.BookmarkStart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.BookmarkStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BookmarkStartConverter.CreateOpenXmlElement<DXW.BookmarkStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MarkupRangeType? GetBookmarkEnd(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXW.MarkupRangeTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.BookmarkEnd>());
  }
  
  private static bool CmpBookmarkEnd(DXW.SdtContentRunRuby openXmlElement, DMW.MarkupRangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupRangeTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.BookmarkEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBookmarkEnd(DXW.SdtContentRunRuby openXmlElement, DMW.MarkupRangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.BookmarkEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MarkupRangeTypeConverter.CreateOpenXmlElement<DXW.BookmarkEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MarkupRangeType? GetCommentRangeStart(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXW.MarkupRangeTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.CommentRangeStart>());
  }
  
  private static bool CmpCommentRangeStart(DXW.SdtContentRunRuby openXmlElement, DMW.MarkupRangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupRangeTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.CommentRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCommentRangeStart(DXW.SdtContentRunRuby openXmlElement, DMW.MarkupRangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CommentRangeStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MarkupRangeTypeConverter.CreateOpenXmlElement<DXW.CommentRangeStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MarkupRangeType? GetCommentRangeEnd(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXW.MarkupRangeTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.CommentRangeEnd>());
  }
  
  private static bool CmpCommentRangeEnd(DXW.SdtContentRunRuby openXmlElement, DMW.MarkupRangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupRangeTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.CommentRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCommentRangeEnd(DXW.SdtContentRunRuby openXmlElement, DMW.MarkupRangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CommentRangeEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MarkupRangeTypeConverter.CreateOpenXmlElement<DXW.CommentRangeEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MoveBookmarkType? GetMoveFromRangeStart(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXW.MoveBookmarkTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.MoveFromRangeStart>());
  }
  
  private static bool CmpMoveFromRangeStart(DXW.SdtContentRunRuby openXmlElement, DMW.MoveBookmarkType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MoveBookmarkTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.MoveFromRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMoveFromRangeStart(DXW.SdtContentRunRuby openXmlElement, DMW.MoveBookmarkType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MoveFromRangeStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MoveBookmarkTypeConverter.CreateOpenXmlElement<DXW.MoveFromRangeStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MarkupRangeType? GetMoveFromRangeEnd(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXW.MarkupRangeTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.MoveFromRangeEnd>());
  }
  
  private static bool CmpMoveFromRangeEnd(DXW.SdtContentRunRuby openXmlElement, DMW.MarkupRangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupRangeTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.MoveFromRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMoveFromRangeEnd(DXW.SdtContentRunRuby openXmlElement, DMW.MarkupRangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MoveFromRangeEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MarkupRangeTypeConverter.CreateOpenXmlElement<DXW.MoveFromRangeEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MoveBookmarkType? GetMoveToRangeStart(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXW.MoveBookmarkTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.MoveToRangeStart>());
  }
  
  private static bool CmpMoveToRangeStart(DXW.SdtContentRunRuby openXmlElement, DMW.MoveBookmarkType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MoveBookmarkTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.MoveToRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMoveToRangeStart(DXW.SdtContentRunRuby openXmlElement, DMW.MoveBookmarkType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MoveToRangeStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MoveBookmarkTypeConverter.CreateOpenXmlElement<DXW.MoveToRangeStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MarkupRangeType? GetMoveToRangeEnd(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXW.MarkupRangeTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.MoveToRangeEnd>());
  }
  
  private static bool CmpMoveToRangeEnd(DXW.SdtContentRunRuby openXmlElement, DMW.MarkupRangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupRangeTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.MoveToRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMoveToRangeEnd(DXW.SdtContentRunRuby openXmlElement, DMW.MarkupRangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MoveToRangeEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MarkupRangeTypeConverter.CreateOpenXmlElement<DXW.MoveToRangeEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.TrackChangeType? GetCustomXmlInsRangeStart(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXW.TrackChangeTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlInsRangeStart>());
  }
  
  private static bool CmpCustomXmlInsRangeStart(DXW.SdtContentRunRuby openXmlElement, DMW.TrackChangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlInsRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlInsRangeStart(DXW.SdtContentRunRuby openXmlElement, DMW.TrackChangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CustomXmlInsRangeStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TrackChangeTypeConverter.CreateOpenXmlElement<DXW.CustomXmlInsRangeStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MarkupType? GetCustomXmlInsRangeEnd(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXW.MarkupTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlInsRangeEnd>());
  }
  
  private static bool CmpCustomXmlInsRangeEnd(DXW.SdtContentRunRuby openXmlElement, DMW.MarkupType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlInsRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlInsRangeEnd(DXW.SdtContentRunRuby openXmlElement, DMW.MarkupType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CustomXmlInsRangeEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MarkupTypeConverter.CreateOpenXmlElement<DXW.CustomXmlInsRangeEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.TrackChangeType? GetCustomXmlDelRangeStart(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXW.TrackChangeTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlDelRangeStart>());
  }
  
  private static bool CmpCustomXmlDelRangeStart(DXW.SdtContentRunRuby openXmlElement, DMW.TrackChangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlDelRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlDelRangeStart(DXW.SdtContentRunRuby openXmlElement, DMW.TrackChangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CustomXmlDelRangeStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TrackChangeTypeConverter.CreateOpenXmlElement<DXW.CustomXmlDelRangeStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MarkupType? GetCustomXmlDelRangeEnd(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXW.MarkupTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlDelRangeEnd>());
  }
  
  private static bool CmpCustomXmlDelRangeEnd(DXW.SdtContentRunRuby openXmlElement, DMW.MarkupType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlDelRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlDelRangeEnd(DXW.SdtContentRunRuby openXmlElement, DMW.MarkupType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CustomXmlDelRangeEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MarkupTypeConverter.CreateOpenXmlElement<DXW.CustomXmlDelRangeEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.TrackChangeType? GetCustomXmlMoveFromRangeStart(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXW.TrackChangeTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlMoveFromRangeStart>());
  }
  
  private static bool CmpCustomXmlMoveFromRangeStart(DXW.SdtContentRunRuby openXmlElement, DMW.TrackChangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlMoveFromRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlMoveFromRangeStart(DXW.SdtContentRunRuby openXmlElement, DMW.TrackChangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CustomXmlMoveFromRangeStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TrackChangeTypeConverter.CreateOpenXmlElement<DXW.CustomXmlMoveFromRangeStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MarkupType? GetCustomXmlMoveFromRangeEnd(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXW.MarkupTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlMoveFromRangeEnd>());
  }
  
  private static bool CmpCustomXmlMoveFromRangeEnd(DXW.SdtContentRunRuby openXmlElement, DMW.MarkupType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlMoveFromRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlMoveFromRangeEnd(DXW.SdtContentRunRuby openXmlElement, DMW.MarkupType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CustomXmlMoveFromRangeEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MarkupTypeConverter.CreateOpenXmlElement<DXW.CustomXmlMoveFromRangeEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.TrackChangeType? GetCustomXmlMoveToRangeStart(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXW.TrackChangeTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlMoveToRangeStart>());
  }
  
  private static bool CmpCustomXmlMoveToRangeStart(DXW.SdtContentRunRuby openXmlElement, DMW.TrackChangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlMoveToRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlMoveToRangeStart(DXW.SdtContentRunRuby openXmlElement, DMW.TrackChangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CustomXmlMoveToRangeStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TrackChangeTypeConverter.CreateOpenXmlElement<DXW.CustomXmlMoveToRangeStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MarkupType? GetCustomXmlMoveToRangeEnd(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXW.MarkupTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlMoveToRangeEnd>());
  }
  
  private static bool CmpCustomXmlMoveToRangeEnd(DXW.SdtContentRunRuby openXmlElement, DMW.MarkupType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlMoveToRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlMoveToRangeEnd(DXW.SdtContentRunRuby openXmlElement, DMW.MarkupType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CustomXmlMoveToRangeEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MarkupTypeConverter.CreateOpenXmlElement<DXW.CustomXmlMoveToRangeEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.TrackChangeType2? GetCustomXmlConflictInsertionRangeStart(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXW.TrackChangeType2Converter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictInsertionRangeStart>());
  }
  
  private static bool CmpCustomXmlConflictInsertionRangeStart(DXW.SdtContentRunRuby openXmlElement, DMW.TrackChangeType2? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeType2Converter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictInsertionRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlConflictInsertionRangeStart(DXW.SdtContentRunRuby openXmlElement, DMW.TrackChangeType2? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.CustomXmlConflictInsertionRangeStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TrackChangeType2Converter.CreateOpenXmlElement<DXO2010W.CustomXmlConflictInsertionRangeStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MarkupType2? GetCustomXmlConflictInsertionRangeEnd(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXW.MarkupType2Converter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictInsertionRangeEnd>());
  }
  
  private static bool CmpCustomXmlConflictInsertionRangeEnd(DXW.SdtContentRunRuby openXmlElement, DMW.MarkupType2? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupType2Converter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictInsertionRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlConflictInsertionRangeEnd(DXW.SdtContentRunRuby openXmlElement, DMW.MarkupType2? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.CustomXmlConflictInsertionRangeEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MarkupType2Converter.CreateOpenXmlElement<DXO2010W.CustomXmlConflictInsertionRangeEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.TrackChangeType2? GetCustomXmlConflictDeletionRangeStart(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXW.TrackChangeType2Converter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictDeletionRangeStart>());
  }
  
  private static bool CmpCustomXmlConflictDeletionRangeStart(DXW.SdtContentRunRuby openXmlElement, DMW.TrackChangeType2? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeType2Converter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictDeletionRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlConflictDeletionRangeStart(DXW.SdtContentRunRuby openXmlElement, DMW.TrackChangeType2? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.CustomXmlConflictDeletionRangeStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TrackChangeType2Converter.CreateOpenXmlElement<DXO2010W.CustomXmlConflictDeletionRangeStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MarkupType2? GetCustomXmlConflictDeletionRangeEnd(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXW.MarkupType2Converter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictDeletionRangeEnd>());
  }
  
  private static bool CmpCustomXmlConflictDeletionRangeEnd(DXW.SdtContentRunRuby openXmlElement, DMW.MarkupType2? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupType2Converter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictDeletionRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlConflictDeletionRangeEnd(DXW.SdtContentRunRuby openXmlElement, DMW.MarkupType2? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.CustomXmlConflictDeletionRangeEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MarkupType2Converter.CreateOpenXmlElement<DXO2010W.CustomXmlConflictDeletionRangeEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.InsertedRun? GetInsertedRun(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXW.InsertedRunConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.InsertedRun>());
  }
  
  private static bool CmpInsertedRun(DXW.SdtContentRunRuby openXmlElement, DMW.InsertedRun? value, DiffList? diffs, string? objName)
  {
    return DMXW.InsertedRunConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.InsertedRun>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetInsertedRun(DXW.SdtContentRunRuby openXmlElement, DMW.InsertedRun? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.InsertedRun>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.InsertedRunConverter.CreateOpenXmlElement<DXW.InsertedRun>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.DeletedRun? GetDeletedRun(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXW.DeletedRunConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.DeletedRun>());
  }
  
  private static bool CmpDeletedRun(DXW.SdtContentRunRuby openXmlElement, DMW.DeletedRun? value, DiffList? diffs, string? objName)
  {
    return DMXW.DeletedRunConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.DeletedRun>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDeletedRun(DXW.SdtContentRunRuby openXmlElement, DMW.DeletedRun? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DeletedRun>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.DeletedRunConverter.CreateOpenXmlElement<DXW.DeletedRun>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MoveFromRun? GetMoveFromRun(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXW.MoveFromRunConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.MoveFromRun>());
  }
  
  private static bool CmpMoveFromRun(DXW.SdtContentRunRuby openXmlElement, DMW.MoveFromRun? value, DiffList? diffs, string? objName)
  {
    return DMXW.MoveFromRunConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.MoveFromRun>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMoveFromRun(DXW.SdtContentRunRuby openXmlElement, DMW.MoveFromRun? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MoveFromRun>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MoveFromRunConverter.CreateOpenXmlElement<DXW.MoveFromRun>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MoveToRun? GetMoveToRun(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXW.MoveToRunConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.MoveToRun>());
  }
  
  private static bool CmpMoveToRun(DXW.SdtContentRunRuby openXmlElement, DMW.MoveToRun? value, DiffList? diffs, string? objName)
  {
    return DMXW.MoveToRunConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.MoveToRun>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMoveToRun(DXW.SdtContentRunRuby openXmlElement, DMW.MoveToRun? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MoveToRun>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MoveToRunConverter.CreateOpenXmlElement<DXW.MoveToRun>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.RunConflictInsertion? GetRunConflictInsertion(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXW.RunConflictInsertionConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010W.RunConflictInsertion>());
  }
  
  private static bool CmpRunConflictInsertion(DXW.SdtContentRunRuby openXmlElement, DMW.RunConflictInsertion? value, DiffList? diffs, string? objName)
  {
    return DMXW.RunConflictInsertionConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2010W.RunConflictInsertion>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRunConflictInsertion(DXW.SdtContentRunRuby openXmlElement, DMW.RunConflictInsertion? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.RunConflictInsertion>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RunConflictInsertionConverter.CreateOpenXmlElement<DXO2010W.RunConflictInsertion>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.RunConflictDeletion? GetRunConflictDeletion(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXW.RunConflictDeletionConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010W.RunConflictDeletion>());
  }
  
  private static bool CmpRunConflictDeletion(DXW.SdtContentRunRuby openXmlElement, DMW.RunConflictDeletion? value, DiffList? diffs, string? objName)
  {
    return DMXW.RunConflictDeletionConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2010W.RunConflictDeletion>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRunConflictDeletion(DXW.SdtContentRunRuby openXmlElement, DMW.RunConflictDeletion? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.RunConflictDeletion>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RunConflictDeletionConverter.CreateOpenXmlElement<DXO2010W.RunConflictDeletion>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Paragraph? GetParagraph(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXMath.ParagraphConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.Paragraph>());
  }
  
  private static bool CmpParagraph(DXW.SdtContentRunRuby openXmlElement, DMMath.Paragraph? value, DiffList? diffs, string? objName)
  {
    return DMXMath.ParagraphConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.Paragraph>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetParagraph(DXW.SdtContentRunRuby openXmlElement, DMMath.Paragraph? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Paragraph>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.ParagraphConverter.CreateOpenXmlElement<DXMath.Paragraph>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.OfficeMath? GetOfficeMath(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXMath.OfficeMathConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.OfficeMath>());
  }
  
  private static bool CmpOfficeMath(DXW.SdtContentRunRuby openXmlElement, DMMath.OfficeMath? value, DiffList? diffs, string? objName)
  {
    return DMXMath.OfficeMathConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.OfficeMath>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetOfficeMath(DXW.SdtContentRunRuby openXmlElement, DMMath.OfficeMath? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.OfficeMath>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.OfficeMathConverter.CreateOpenXmlElement<DXMath.OfficeMath>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Accent? GetAccent(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXMath.AccentConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.Accent>());
  }
  
  private static bool CmpAccent(DXW.SdtContentRunRuby openXmlElement, DMMath.Accent? value, DiffList? diffs, string? objName)
  {
    return DMXMath.AccentConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.Accent>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetAccent(DXW.SdtContentRunRuby openXmlElement, DMMath.Accent? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Accent>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.AccentConverter.CreateOpenXmlElement<DXMath.Accent>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Bar? GetBar(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXMath.BarConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.Bar>());
  }
  
  private static bool CmpBar(DXW.SdtContentRunRuby openXmlElement, DMMath.Bar? value, DiffList? diffs, string? objName)
  {
    return DMXMath.BarConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.Bar>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBar(DXW.SdtContentRunRuby openXmlElement, DMMath.Bar? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Bar>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.BarConverter.CreateOpenXmlElement<DXMath.Bar>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Box? GetBox(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXMath.BoxConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.Box>());
  }
  
  private static bool CmpBox(DXW.SdtContentRunRuby openXmlElement, DMMath.Box? value, DiffList? diffs, string? objName)
  {
    return DMXMath.BoxConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.Box>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBox(DXW.SdtContentRunRuby openXmlElement, DMMath.Box? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Box>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.BoxConverter.CreateOpenXmlElement<DXMath.Box>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.BorderBox? GetBorderBox(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXMath.BorderBoxConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.BorderBox>());
  }
  
  private static bool CmpBorderBox(DXW.SdtContentRunRuby openXmlElement, DMMath.BorderBox? value, DiffList? diffs, string? objName)
  {
    return DMXMath.BorderBoxConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.BorderBox>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBorderBox(DXW.SdtContentRunRuby openXmlElement, DMMath.BorderBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.BorderBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.BorderBoxConverter.CreateOpenXmlElement<DXMath.BorderBox>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Delimiter? GetDelimiter(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXMath.DelimiterConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.Delimiter>());
  }
  
  private static bool CmpDelimiter(DXW.SdtContentRunRuby openXmlElement, DMMath.Delimiter? value, DiffList? diffs, string? objName)
  {
    return DMXMath.DelimiterConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.Delimiter>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDelimiter(DXW.SdtContentRunRuby openXmlElement, DMMath.Delimiter? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Delimiter>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.DelimiterConverter.CreateOpenXmlElement<DXMath.Delimiter>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.EquationArray? GetEquationArray(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXMath.EquationArrayConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.EquationArray>());
  }
  
  private static bool CmpEquationArray(DXW.SdtContentRunRuby openXmlElement, DMMath.EquationArray? value, DiffList? diffs, string? objName)
  {
    return DMXMath.EquationArrayConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.EquationArray>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetEquationArray(DXW.SdtContentRunRuby openXmlElement, DMMath.EquationArray? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.EquationArray>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.EquationArrayConverter.CreateOpenXmlElement<DXMath.EquationArray>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Fraction? GetFraction(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXMath.FractionConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.Fraction>());
  }
  
  private static bool CmpFraction(DXW.SdtContentRunRuby openXmlElement, DMMath.Fraction? value, DiffList? diffs, string? objName)
  {
    return DMXMath.FractionConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.Fraction>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFraction(DXW.SdtContentRunRuby openXmlElement, DMMath.Fraction? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Fraction>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.FractionConverter.CreateOpenXmlElement<DXMath.Fraction>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.MathFunction? GetMathFunction(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXMath.MathFunctionConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.MathFunction>());
  }
  
  private static bool CmpMathFunction(DXW.SdtContentRunRuby openXmlElement, DMMath.MathFunction? value, DiffList? diffs, string? objName)
  {
    return DMXMath.MathFunctionConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.MathFunction>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMathFunction(DXW.SdtContentRunRuby openXmlElement, DMMath.MathFunction? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.MathFunction>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.MathFunctionConverter.CreateOpenXmlElement<DXMath.MathFunction>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.GroupChar? GetGroupChar(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXMath.GroupCharConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.GroupChar>());
  }
  
  private static bool CmpGroupChar(DXW.SdtContentRunRuby openXmlElement, DMMath.GroupChar? value, DiffList? diffs, string? objName)
  {
    return DMXMath.GroupCharConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.GroupChar>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetGroupChar(DXW.SdtContentRunRuby openXmlElement, DMMath.GroupChar? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.GroupChar>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.GroupCharConverter.CreateOpenXmlElement<DXMath.GroupChar>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.LimitLower? GetLimitLower(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXMath.LimitLowerConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.LimitLower>());
  }
  
  private static bool CmpLimitLower(DXW.SdtContentRunRuby openXmlElement, DMMath.LimitLower? value, DiffList? diffs, string? objName)
  {
    return DMXMath.LimitLowerConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.LimitLower>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLimitLower(DXW.SdtContentRunRuby openXmlElement, DMMath.LimitLower? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.LimitLower>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.LimitLowerConverter.CreateOpenXmlElement<DXMath.LimitLower>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.LimitUpper? GetLimitUpper(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXMath.LimitUpperConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.LimitUpper>());
  }
  
  private static bool CmpLimitUpper(DXW.SdtContentRunRuby openXmlElement, DMMath.LimitUpper? value, DiffList? diffs, string? objName)
  {
    return DMXMath.LimitUpperConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.LimitUpper>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLimitUpper(DXW.SdtContentRunRuby openXmlElement, DMMath.LimitUpper? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.LimitUpper>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.LimitUpperConverter.CreateOpenXmlElement<DXMath.LimitUpper>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Matrix? GetMatrix(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXMath.MatrixConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.Matrix>());
  }
  
  private static bool CmpMatrix(DXW.SdtContentRunRuby openXmlElement, DMMath.Matrix? value, DiffList? diffs, string? objName)
  {
    return DMXMath.MatrixConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.Matrix>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMatrix(DXW.SdtContentRunRuby openXmlElement, DMMath.Matrix? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Matrix>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.MatrixConverter.CreateOpenXmlElement<DXMath.Matrix>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Nary? GetNary(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXMath.NaryConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.Nary>());
  }
  
  private static bool CmpNary(DXW.SdtContentRunRuby openXmlElement, DMMath.Nary? value, DiffList? diffs, string? objName)
  {
    return DMXMath.NaryConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.Nary>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNary(DXW.SdtContentRunRuby openXmlElement, DMMath.Nary? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Nary>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.NaryConverter.CreateOpenXmlElement<DXMath.Nary>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Phantom? GetPhantom(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXMath.PhantomConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.Phantom>());
  }
  
  private static bool CmpPhantom(DXW.SdtContentRunRuby openXmlElement, DMMath.Phantom? value, DiffList? diffs, string? objName)
  {
    return DMXMath.PhantomConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.Phantom>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPhantom(DXW.SdtContentRunRuby openXmlElement, DMMath.Phantom? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Phantom>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.PhantomConverter.CreateOpenXmlElement<DXMath.Phantom>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Radical? GetRadical(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXMath.RadicalConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.Radical>());
  }
  
  private static bool CmpRadical(DXW.SdtContentRunRuby openXmlElement, DMMath.Radical? value, DiffList? diffs, string? objName)
  {
    return DMXMath.RadicalConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.Radical>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRadical(DXW.SdtContentRunRuby openXmlElement, DMMath.Radical? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Radical>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.RadicalConverter.CreateOpenXmlElement<DXMath.Radical>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.PreSubSuper? GetPreSubSuper(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXMath.PreSubSuperConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.PreSubSuper>());
  }
  
  private static bool CmpPreSubSuper(DXW.SdtContentRunRuby openXmlElement, DMMath.PreSubSuper? value, DiffList? diffs, string? objName)
  {
    return DMXMath.PreSubSuperConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.PreSubSuper>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPreSubSuper(DXW.SdtContentRunRuby openXmlElement, DMMath.PreSubSuper? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.PreSubSuper>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.PreSubSuperConverter.CreateOpenXmlElement<DXMath.PreSubSuper>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Subscript? GetSubscript(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXMath.SubscriptConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.Subscript>());
  }
  
  private static bool CmpSubscript(DXW.SdtContentRunRuby openXmlElement, DMMath.Subscript? value, DiffList? diffs, string? objName)
  {
    return DMXMath.SubscriptConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.Subscript>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSubscript(DXW.SdtContentRunRuby openXmlElement, DMMath.Subscript? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Subscript>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.SubscriptConverter.CreateOpenXmlElement<DXMath.Subscript>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.SubSuperscript? GetSubSuperscript(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXMath.SubSuperscriptConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.SubSuperscript>());
  }
  
  private static bool CmpSubSuperscript(DXW.SdtContentRunRuby openXmlElement, DMMath.SubSuperscript? value, DiffList? diffs, string? objName)
  {
    return DMXMath.SubSuperscriptConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.SubSuperscript>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSubSuperscript(DXW.SdtContentRunRuby openXmlElement, DMMath.SubSuperscript? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.SubSuperscript>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.SubSuperscriptConverter.CreateOpenXmlElement<DXMath.SubSuperscript>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Superscript? GetSuperscript(DXW.SdtContentRunRuby openXmlElement)
  {
    return DMXMath.SuperscriptConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.Superscript>());
  }
  
  private static bool CmpSuperscript(DXW.SdtContentRunRuby openXmlElement, DMMath.Superscript? value, DiffList? diffs, string? objName)
  {
    return DMXMath.SuperscriptConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.Superscript>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSuperscript(DXW.SdtContentRunRuby openXmlElement, DMMath.Superscript? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Superscript>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.SuperscriptConverter.CreateOpenXmlElement<DXMath.Superscript>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.SdtContentRunRuby? CreateModelElement(DXW.SdtContentRunRuby? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.SdtContentRunRuby();
      value.CustomXmlRuby = GetCustomXmlRuby(openXmlElement);
      value.SimpleFieldRuby = GetSimpleFieldRuby(openXmlElement);
      value.HyperlinkRuby = GetHyperlinkRuby(openXmlElement);
      value.Run = GetRun(openXmlElement);
      value.SdtRunRuby = GetSdtRunRuby(openXmlElement);
      value.ProofError = GetProofError(openXmlElement);
      value.PermStart = GetPermStart(openXmlElement);
      value.PermEnd = GetPermEnd(openXmlElement);
      value.BookmarkStart = GetBookmarkStart(openXmlElement);
      value.BookmarkEnd = GetBookmarkEnd(openXmlElement);
      value.CommentRangeStart = GetCommentRangeStart(openXmlElement);
      value.CommentRangeEnd = GetCommentRangeEnd(openXmlElement);
      value.MoveFromRangeStart = GetMoveFromRangeStart(openXmlElement);
      value.MoveFromRangeEnd = GetMoveFromRangeEnd(openXmlElement);
      value.MoveToRangeStart = GetMoveToRangeStart(openXmlElement);
      value.MoveToRangeEnd = GetMoveToRangeEnd(openXmlElement);
      value.CustomXmlInsRangeStart = GetCustomXmlInsRangeStart(openXmlElement);
      value.CustomXmlInsRangeEnd = GetCustomXmlInsRangeEnd(openXmlElement);
      value.CustomXmlDelRangeStart = GetCustomXmlDelRangeStart(openXmlElement);
      value.CustomXmlDelRangeEnd = GetCustomXmlDelRangeEnd(openXmlElement);
      value.CustomXmlMoveFromRangeStart = GetCustomXmlMoveFromRangeStart(openXmlElement);
      value.CustomXmlMoveFromRangeEnd = GetCustomXmlMoveFromRangeEnd(openXmlElement);
      value.CustomXmlMoveToRangeStart = GetCustomXmlMoveToRangeStart(openXmlElement);
      value.CustomXmlMoveToRangeEnd = GetCustomXmlMoveToRangeEnd(openXmlElement);
      value.CustomXmlConflictInsertionRangeStart = GetCustomXmlConflictInsertionRangeStart(openXmlElement);
      value.CustomXmlConflictInsertionRangeEnd = GetCustomXmlConflictInsertionRangeEnd(openXmlElement);
      value.CustomXmlConflictDeletionRangeStart = GetCustomXmlConflictDeletionRangeStart(openXmlElement);
      value.CustomXmlConflictDeletionRangeEnd = GetCustomXmlConflictDeletionRangeEnd(openXmlElement);
      value.InsertedRun = GetInsertedRun(openXmlElement);
      value.DeletedRun = GetDeletedRun(openXmlElement);
      value.MoveFromRun = GetMoveFromRun(openXmlElement);
      value.MoveToRun = GetMoveToRun(openXmlElement);
      value.RunConflictInsertion = GetRunConflictInsertion(openXmlElement);
      value.RunConflictDeletion = GetRunConflictDeletion(openXmlElement);
      value.Paragraph = GetParagraph(openXmlElement);
      value.OfficeMath = GetOfficeMath(openXmlElement);
      value.Accent = GetAccent(openXmlElement);
      value.Bar = GetBar(openXmlElement);
      value.Box = GetBox(openXmlElement);
      value.BorderBox = GetBorderBox(openXmlElement);
      value.Delimiter = GetDelimiter(openXmlElement);
      value.EquationArray = GetEquationArray(openXmlElement);
      value.Fraction = GetFraction(openXmlElement);
      value.MathFunction = GetMathFunction(openXmlElement);
      value.GroupChar = GetGroupChar(openXmlElement);
      value.LimitLower = GetLimitLower(openXmlElement);
      value.LimitUpper = GetLimitUpper(openXmlElement);
      value.Matrix = GetMatrix(openXmlElement);
      value.Nary = GetNary(openXmlElement);
      value.Phantom = GetPhantom(openXmlElement);
      value.Radical = GetRadical(openXmlElement);
      value.PreSubSuper = GetPreSubSuper(openXmlElement);
      value.Subscript = GetSubscript(openXmlElement);
      value.SubSuperscript = GetSubSuperscript(openXmlElement);
      value.Superscript = GetSuperscript(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.SdtContentRunRuby? openXmlElement, DMW.SdtContentRunRuby? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpCustomXmlRuby(openXmlElement, value.CustomXmlRuby, diffs, objName))
        ok = false;
      if (!CmpSimpleFieldRuby(openXmlElement, value.SimpleFieldRuby, diffs, objName))
        ok = false;
      if (!CmpHyperlinkRuby(openXmlElement, value.HyperlinkRuby, diffs, objName))
        ok = false;
      if (!CmpRun(openXmlElement, value.Run, diffs, objName))
        ok = false;
      if (!CmpSdtRunRuby(openXmlElement, value.SdtRunRuby, diffs, objName))
        ok = false;
      if (!CmpProofError(openXmlElement, value.ProofError, diffs, objName))
        ok = false;
      if (!CmpPermStart(openXmlElement, value.PermStart, diffs, objName))
        ok = false;
      if (!CmpPermEnd(openXmlElement, value.PermEnd, diffs, objName))
        ok = false;
      if (!CmpBookmarkStart(openXmlElement, value.BookmarkStart, diffs, objName))
        ok = false;
      if (!CmpBookmarkEnd(openXmlElement, value.BookmarkEnd, diffs, objName))
        ok = false;
      if (!CmpCommentRangeStart(openXmlElement, value.CommentRangeStart, diffs, objName))
        ok = false;
      if (!CmpCommentRangeEnd(openXmlElement, value.CommentRangeEnd, diffs, objName))
        ok = false;
      if (!CmpMoveFromRangeStart(openXmlElement, value.MoveFromRangeStart, diffs, objName))
        ok = false;
      if (!CmpMoveFromRangeEnd(openXmlElement, value.MoveFromRangeEnd, diffs, objName))
        ok = false;
      if (!CmpMoveToRangeStart(openXmlElement, value.MoveToRangeStart, diffs, objName))
        ok = false;
      if (!CmpMoveToRangeEnd(openXmlElement, value.MoveToRangeEnd, diffs, objName))
        ok = false;
      if (!CmpCustomXmlInsRangeStart(openXmlElement, value.CustomXmlInsRangeStart, diffs, objName))
        ok = false;
      if (!CmpCustomXmlInsRangeEnd(openXmlElement, value.CustomXmlInsRangeEnd, diffs, objName))
        ok = false;
      if (!CmpCustomXmlDelRangeStart(openXmlElement, value.CustomXmlDelRangeStart, diffs, objName))
        ok = false;
      if (!CmpCustomXmlDelRangeEnd(openXmlElement, value.CustomXmlDelRangeEnd, diffs, objName))
        ok = false;
      if (!CmpCustomXmlMoveFromRangeStart(openXmlElement, value.CustomXmlMoveFromRangeStart, diffs, objName))
        ok = false;
      if (!CmpCustomXmlMoveFromRangeEnd(openXmlElement, value.CustomXmlMoveFromRangeEnd, diffs, objName))
        ok = false;
      if (!CmpCustomXmlMoveToRangeStart(openXmlElement, value.CustomXmlMoveToRangeStart, diffs, objName))
        ok = false;
      if (!CmpCustomXmlMoveToRangeEnd(openXmlElement, value.CustomXmlMoveToRangeEnd, diffs, objName))
        ok = false;
      if (!CmpCustomXmlConflictInsertionRangeStart(openXmlElement, value.CustomXmlConflictInsertionRangeStart, diffs, objName))
        ok = false;
      if (!CmpCustomXmlConflictInsertionRangeEnd(openXmlElement, value.CustomXmlConflictInsertionRangeEnd, diffs, objName))
        ok = false;
      if (!CmpCustomXmlConflictDeletionRangeStart(openXmlElement, value.CustomXmlConflictDeletionRangeStart, diffs, objName))
        ok = false;
      if (!CmpCustomXmlConflictDeletionRangeEnd(openXmlElement, value.CustomXmlConflictDeletionRangeEnd, diffs, objName))
        ok = false;
      if (!CmpInsertedRun(openXmlElement, value.InsertedRun, diffs, objName))
        ok = false;
      if (!CmpDeletedRun(openXmlElement, value.DeletedRun, diffs, objName))
        ok = false;
      if (!CmpMoveFromRun(openXmlElement, value.MoveFromRun, diffs, objName))
        ok = false;
      if (!CmpMoveToRun(openXmlElement, value.MoveToRun, diffs, objName))
        ok = false;
      if (!CmpRunConflictInsertion(openXmlElement, value.RunConflictInsertion, diffs, objName))
        ok = false;
      if (!CmpRunConflictDeletion(openXmlElement, value.RunConflictDeletion, diffs, objName))
        ok = false;
      if (!CmpParagraph(openXmlElement, value.Paragraph, diffs, objName))
        ok = false;
      if (!CmpOfficeMath(openXmlElement, value.OfficeMath, diffs, objName))
        ok = false;
      if (!CmpAccent(openXmlElement, value.Accent, diffs, objName))
        ok = false;
      if (!CmpBar(openXmlElement, value.Bar, diffs, objName))
        ok = false;
      if (!CmpBox(openXmlElement, value.Box, diffs, objName))
        ok = false;
      if (!CmpBorderBox(openXmlElement, value.BorderBox, diffs, objName))
        ok = false;
      if (!CmpDelimiter(openXmlElement, value.Delimiter, diffs, objName))
        ok = false;
      if (!CmpEquationArray(openXmlElement, value.EquationArray, diffs, objName))
        ok = false;
      if (!CmpFraction(openXmlElement, value.Fraction, diffs, objName))
        ok = false;
      if (!CmpMathFunction(openXmlElement, value.MathFunction, diffs, objName))
        ok = false;
      if (!CmpGroupChar(openXmlElement, value.GroupChar, diffs, objName))
        ok = false;
      if (!CmpLimitLower(openXmlElement, value.LimitLower, diffs, objName))
        ok = false;
      if (!CmpLimitUpper(openXmlElement, value.LimitUpper, diffs, objName))
        ok = false;
      if (!CmpMatrix(openXmlElement, value.Matrix, diffs, objName))
        ok = false;
      if (!CmpNary(openXmlElement, value.Nary, diffs, objName))
        ok = false;
      if (!CmpPhantom(openXmlElement, value.Phantom, diffs, objName))
        ok = false;
      if (!CmpRadical(openXmlElement, value.Radical, diffs, objName))
        ok = false;
      if (!CmpPreSubSuper(openXmlElement, value.PreSubSuper, diffs, objName))
        ok = false;
      if (!CmpSubscript(openXmlElement, value.Subscript, diffs, objName))
        ok = false;
      if (!CmpSubSuperscript(openXmlElement, value.SubSuperscript, diffs, objName))
        ok = false;
      if (!CmpSuperscript(openXmlElement, value.Superscript, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.SdtContentRunRuby? value)
    where OpenXmlElementType: DXW.SdtContentRunRuby, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetCustomXmlRuby(openXmlElement, value?.CustomXmlRuby);
      SetSimpleFieldRuby(openXmlElement, value?.SimpleFieldRuby);
      SetHyperlinkRuby(openXmlElement, value?.HyperlinkRuby);
      SetRun(openXmlElement, value?.Run);
      SetSdtRunRuby(openXmlElement, value?.SdtRunRuby);
      SetProofError(openXmlElement, value?.ProofError);
      SetPermStart(openXmlElement, value?.PermStart);
      SetPermEnd(openXmlElement, value?.PermEnd);
      SetBookmarkStart(openXmlElement, value?.BookmarkStart);
      SetBookmarkEnd(openXmlElement, value?.BookmarkEnd);
      SetCommentRangeStart(openXmlElement, value?.CommentRangeStart);
      SetCommentRangeEnd(openXmlElement, value?.CommentRangeEnd);
      SetMoveFromRangeStart(openXmlElement, value?.MoveFromRangeStart);
      SetMoveFromRangeEnd(openXmlElement, value?.MoveFromRangeEnd);
      SetMoveToRangeStart(openXmlElement, value?.MoveToRangeStart);
      SetMoveToRangeEnd(openXmlElement, value?.MoveToRangeEnd);
      SetCustomXmlInsRangeStart(openXmlElement, value?.CustomXmlInsRangeStart);
      SetCustomXmlInsRangeEnd(openXmlElement, value?.CustomXmlInsRangeEnd);
      SetCustomXmlDelRangeStart(openXmlElement, value?.CustomXmlDelRangeStart);
      SetCustomXmlDelRangeEnd(openXmlElement, value?.CustomXmlDelRangeEnd);
      SetCustomXmlMoveFromRangeStart(openXmlElement, value?.CustomXmlMoveFromRangeStart);
      SetCustomXmlMoveFromRangeEnd(openXmlElement, value?.CustomXmlMoveFromRangeEnd);
      SetCustomXmlMoveToRangeStart(openXmlElement, value?.CustomXmlMoveToRangeStart);
      SetCustomXmlMoveToRangeEnd(openXmlElement, value?.CustomXmlMoveToRangeEnd);
      SetCustomXmlConflictInsertionRangeStart(openXmlElement, value?.CustomXmlConflictInsertionRangeStart);
      SetCustomXmlConflictInsertionRangeEnd(openXmlElement, value?.CustomXmlConflictInsertionRangeEnd);
      SetCustomXmlConflictDeletionRangeStart(openXmlElement, value?.CustomXmlConflictDeletionRangeStart);
      SetCustomXmlConflictDeletionRangeEnd(openXmlElement, value?.CustomXmlConflictDeletionRangeEnd);
      SetInsertedRun(openXmlElement, value?.InsertedRun);
      SetDeletedRun(openXmlElement, value?.DeletedRun);
      SetMoveFromRun(openXmlElement, value?.MoveFromRun);
      SetMoveToRun(openXmlElement, value?.MoveToRun);
      SetRunConflictInsertion(openXmlElement, value?.RunConflictInsertion);
      SetRunConflictDeletion(openXmlElement, value?.RunConflictDeletion);
      SetParagraph(openXmlElement, value?.Paragraph);
      SetOfficeMath(openXmlElement, value?.OfficeMath);
      SetAccent(openXmlElement, value?.Accent);
      SetBar(openXmlElement, value?.Bar);
      SetBox(openXmlElement, value?.Box);
      SetBorderBox(openXmlElement, value?.BorderBox);
      SetDelimiter(openXmlElement, value?.Delimiter);
      SetEquationArray(openXmlElement, value?.EquationArray);
      SetFraction(openXmlElement, value?.Fraction);
      SetMathFunction(openXmlElement, value?.MathFunction);
      SetGroupChar(openXmlElement, value?.GroupChar);
      SetLimitLower(openXmlElement, value?.LimitLower);
      SetLimitUpper(openXmlElement, value?.LimitUpper);
      SetMatrix(openXmlElement, value?.Matrix);
      SetNary(openXmlElement, value?.Nary);
      SetPhantom(openXmlElement, value?.Phantom);
      SetRadical(openXmlElement, value?.Radical);
      SetPreSubSuper(openXmlElement, value?.PreSubSuper);
      SetSubscript(openXmlElement, value?.Subscript);
      SetSubSuperscript(openXmlElement, value?.SubSuperscript);
      SetSuperscript(openXmlElement, value?.Superscript);
      return openXmlElement;
    }
    return default;
  }
}
