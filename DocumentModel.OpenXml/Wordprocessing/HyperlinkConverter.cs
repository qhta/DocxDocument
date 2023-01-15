using DocumentFormat.OpenXml.Office2010.Word;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Math;
using DocumentModel.OpenXml.Math;
using DocumentModel.Wordprocessing;
using BidirectionalEmbedding = DocumentModel.Wordprocessing.BidirectionalEmbedding;
using BidirectionalOverride = DocumentModel.Wordprocessing.BidirectionalOverride;
using BookmarkStart = DocumentModel.Wordprocessing.BookmarkStart;
using CustomXmlRun = DocumentModel.Wordprocessing.CustomXmlRun;
using DeletedRun = DocumentModel.Wordprocessing.DeletedRun;
using InsertedRun = DocumentModel.Wordprocessing.InsertedRun;
using MarkupRangeType = DocumentModel.Wordprocessing.MarkupRangeType;
using MarkupType = DocumentModel.Wordprocessing.MarkupType;
using MoveBookmarkType = DocumentModel.Wordprocessing.MoveBookmarkType;
using MoveFromRun = DocumentModel.Wordprocessing.MoveFromRun;
using MoveToRun = DocumentModel.Wordprocessing.MoveToRun;
using OfficeMath = DocumentModel.Math.OfficeMath;
using Paragraph = DocumentModel.Math.Paragraph;
using PermEnd = DocumentModel.Wordprocessing.PermEnd;
using PermStart = DocumentModel.Wordprocessing.PermStart;
using ProofError = DocumentModel.Wordprocessing.ProofError;
using RelationshipType = DocumentModel.Wordprocessing.RelationshipType;
using Run = DocumentModel.Math.Run;
using RunConflictDeletion = DocumentModel.Wordprocessing.RunConflictDeletion;
using RunConflictInsertion = DocumentModel.Wordprocessing.RunConflictInsertion;
using SdtRun = DocumentModel.Wordprocessing.SdtRun;
using SimpleField = DocumentModel.Wordprocessing.SimpleField;
using TrackChangeType = DocumentModel.Wordprocessing.TrackChangeType;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the Hyperlink Class.
/// </summary>
public static class HyperlinkConverter
{
  /// <summary>
  ///   Hyperlink Target Frame
  /// </summary>
  public static String? GetTargetFrame(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    return openXmlElement?.TargetFrame?.Value;
  }

  public static void SetTargetFrame(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.TargetFrame = new StringValue { Value = value };
      else
        openXmlElement.TargetFrame = null;
  }

  /// <summary>
  ///   Associated String
  /// </summary>
  public static String? GetTooltip(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    return openXmlElement?.Tooltip?.Value;
  }

  public static void SetTooltip(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Tooltip = new StringValue { Value = value };
      else
        openXmlElement.Tooltip = null;
  }

  /// <summary>
  ///   Location in Target Document
  /// </summary>
  public static String? GetDocLocation(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    return openXmlElement?.DocLocation?.Value;
  }

  public static void SetDocLocation(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.DocLocation = new StringValue { Value = value };
      else
        openXmlElement.DocLocation = null;
  }

  /// <summary>
  ///   Add To Viewed Hyperlinks
  /// </summary>
  public static Boolean? GetHistory(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    return openXmlElement?.History?.Value;
  }

  public static void SetHistory(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.History = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.History = null;
  }

  /// <summary>
  ///   Hyperlink Anchor
  /// </summary>
  public static String? GetAnchor(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    return openXmlElement?.Anchor?.Value;
  }

  public static void SetAnchor(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Anchor = new StringValue { Value = value };
      else
        openXmlElement.Anchor = null;
  }

  /// <summary>
  ///   Hyperlink Target
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }

  public static CustomXmlRun? GetCustomXmlRun(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun>();
    if (itemElement != null)
      return CustomXmlRunConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomXmlRun(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, CustomXmlRun? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CustomXmlRunConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Collection<SimpleField>? GetSimpleFields(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<SimpleField>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.SimpleField>())
      {
        var newItem = SimpleFieldConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetSimpleFields(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, Collection<SimpleField>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.SimpleField>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = SimpleFieldConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.SimpleField>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Wordprocessing.Hyperlink? GetChildHyperlink(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Hyperlink>();
    if (itemElement != null)
      return CreateModelElement(itemElement);
    return null;
  }

  public static void SetChildHyperlink(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, DocumentModel.Wordprocessing.Hyperlink? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Hyperlink>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Hyperlink>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static SdtRun? GetSdtRun(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtRun>();
    if (itemElement != null)
      return SdtRunConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSdtRun(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, SdtRun? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtRun>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SdtRunConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.SdtRun>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ProofError? GetProofError(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ProofError>();
    if (itemElement != null)
      return ProofErrorConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetProofError(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, ProofError? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ProofError>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ProofErrorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.ProofError>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static PermStart? GetPermStart(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PermStart>();
    if (itemElement != null)
      return PermStartConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPermStart(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, PermStart? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PermStart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PermStartConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.PermStart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static PermEnd? GetPermEnd(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PermEnd>();
    if (itemElement != null)
      return PermEndConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPermEnd(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, PermEnd? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PermEnd>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PermEndConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.PermEnd>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static BookmarkStart? GetBookmarkStart(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BookmarkStart>();
    if (itemElement != null)
      return BookmarkStartConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBookmarkStart(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, BookmarkStart? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BookmarkStart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BookmarkStartConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.BookmarkStart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static MarkupRangeType? GetBookmarkEnd(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<BookmarkEnd>();
    if (itemElement != null)
      return MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBookmarkEnd(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, MarkupRangeType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BookmarkEnd>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MarkupRangeTypeConverter.CreateOpenXmlElement<BookmarkEnd>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static MarkupRangeType? GetCommentRangeStart(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CommentRangeStart>();
    if (itemElement != null)
      return MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCommentRangeStart(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, MarkupRangeType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<CommentRangeStart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MarkupRangeTypeConverter.CreateOpenXmlElement<CommentRangeStart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static MarkupRangeType? GetCommentRangeEnd(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CommentRangeEnd>();
    if (itemElement != null)
      return MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCommentRangeEnd(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, MarkupRangeType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<CommentRangeEnd>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MarkupRangeTypeConverter.CreateOpenXmlElement<CommentRangeEnd>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static MoveBookmarkType? GetMoveFromRangeStart(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<MoveFromRangeStart>();
    if (itemElement != null)
      return MoveBookmarkTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMoveFromRangeStart(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, MoveBookmarkType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MoveFromRangeStart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MoveBookmarkTypeConverter.CreateOpenXmlElement<MoveFromRangeStart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static MarkupRangeType? GetMoveFromRangeEnd(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<MoveFromRangeEnd>();
    if (itemElement != null)
      return MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMoveFromRangeEnd(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, MarkupRangeType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MoveFromRangeEnd>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MarkupRangeTypeConverter.CreateOpenXmlElement<MoveFromRangeEnd>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static MoveBookmarkType? GetMoveToRangeStart(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<MoveToRangeStart>();
    if (itemElement != null)
      return MoveBookmarkTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMoveToRangeStart(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, MoveBookmarkType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MoveToRangeStart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MoveBookmarkTypeConverter.CreateOpenXmlElement<MoveToRangeStart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static MarkupRangeType? GetMoveToRangeEnd(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<MoveToRangeEnd>();
    if (itemElement != null)
      return MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMoveToRangeEnd(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, MarkupRangeType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MoveToRangeEnd>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MarkupRangeTypeConverter.CreateOpenXmlElement<MoveToRangeEnd>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TrackChangeType? GetCustomXmlInsRangeStart(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CustomXmlInsRangeStart>();
    if (itemElement != null)
      return TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomXmlInsRangeStart(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, TrackChangeType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<CustomXmlInsRangeStart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TrackChangeTypeConverter.CreateOpenXmlElement<CustomXmlInsRangeStart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static MarkupType? GetCustomXmlInsRangeEnd(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CustomXmlInsRangeEnd>();
    if (itemElement != null)
      return MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomXmlInsRangeEnd(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, MarkupType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<CustomXmlInsRangeEnd>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MarkupTypeConverter.CreateOpenXmlElement<CustomXmlInsRangeEnd>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TrackChangeType? GetCustomXmlDelRangeStart(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CustomXmlDelRangeStart>();
    if (itemElement != null)
      return TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomXmlDelRangeStart(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, TrackChangeType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<CustomXmlDelRangeStart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TrackChangeTypeConverter.CreateOpenXmlElement<CustomXmlDelRangeStart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static MarkupType? GetCustomXmlDelRangeEnd(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CustomXmlDelRangeEnd>();
    if (itemElement != null)
      return MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomXmlDelRangeEnd(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, MarkupType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<CustomXmlDelRangeEnd>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MarkupTypeConverter.CreateOpenXmlElement<CustomXmlDelRangeEnd>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TrackChangeType? GetCustomXmlMoveFromRangeStart(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CustomXmlMoveFromRangeStart>();
    if (itemElement != null)
      return TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomXmlMoveFromRangeStart(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, TrackChangeType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<CustomXmlMoveFromRangeStart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TrackChangeTypeConverter.CreateOpenXmlElement<CustomXmlMoveFromRangeStart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static MarkupType? GetCustomXmlMoveFromRangeEnd(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CustomXmlMoveFromRangeEnd>();
    if (itemElement != null)
      return MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomXmlMoveFromRangeEnd(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, MarkupType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<CustomXmlMoveFromRangeEnd>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MarkupTypeConverter.CreateOpenXmlElement<CustomXmlMoveFromRangeEnd>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TrackChangeType? GetCustomXmlMoveToRangeStart(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CustomXmlMoveToRangeStart>();
    if (itemElement != null)
      return TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomXmlMoveToRangeStart(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, TrackChangeType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<CustomXmlMoveToRangeStart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TrackChangeTypeConverter.CreateOpenXmlElement<CustomXmlMoveToRangeStart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static MarkupType? GetCustomXmlMoveToRangeEnd(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CustomXmlMoveToRangeEnd>();
    if (itemElement != null)
      return MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomXmlMoveToRangeEnd(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, MarkupType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<CustomXmlMoveToRangeEnd>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MarkupTypeConverter.CreateOpenXmlElement<CustomXmlMoveToRangeEnd>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TrackChangeType2? GetCustomXmlConflictInsertionRangeStart(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CustomXmlConflictInsertionRangeStart>();
    if (itemElement != null)
      return TrackChangeType2Converter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomXmlConflictInsertionRangeStart(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, TrackChangeType2? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<CustomXmlConflictInsertionRangeStart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TrackChangeType2Converter.CreateOpenXmlElement<CustomXmlConflictInsertionRangeStart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static MarkupType2? GetCustomXmlConflictInsertionRangeEnd(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CustomXmlConflictInsertionRangeEnd>();
    if (itemElement != null)
      return MarkupType2Converter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomXmlConflictInsertionRangeEnd(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, MarkupType2? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<CustomXmlConflictInsertionRangeEnd>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MarkupType2Converter.CreateOpenXmlElement<CustomXmlConflictInsertionRangeEnd>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TrackChangeType2? GetCustomXmlConflictDeletionRangeStart(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CustomXmlConflictDeletionRangeStart>();
    if (itemElement != null)
      return TrackChangeType2Converter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomXmlConflictDeletionRangeStart(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, TrackChangeType2? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<CustomXmlConflictDeletionRangeStart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TrackChangeType2Converter.CreateOpenXmlElement<CustomXmlConflictDeletionRangeStart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static MarkupType2? GetCustomXmlConflictDeletionRangeEnd(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CustomXmlConflictDeletionRangeEnd>();
    if (itemElement != null)
      return MarkupType2Converter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomXmlConflictDeletionRangeEnd(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, MarkupType2? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<CustomXmlConflictDeletionRangeEnd>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MarkupType2Converter.CreateOpenXmlElement<CustomXmlConflictDeletionRangeEnd>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static InsertedRun? GetInsertedRun(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.InsertedRun>();
    if (itemElement != null)
      return InsertedRunConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetInsertedRun(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, InsertedRun? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.InsertedRun>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = InsertedRunConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.InsertedRun>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DeletedRun? GetDeletedRun(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DeletedRun>();
    if (itemElement != null)
      return DeletedRunConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDeletedRun(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, DeletedRun? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DeletedRun>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DeletedRunConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DeletedRun>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static MoveFromRun? GetMoveFromRun(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromRun>();
    if (itemElement != null)
      return MoveFromRunConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMoveFromRun(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, MoveFromRun? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromRun>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MoveFromRunConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.MoveFromRun>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static MoveToRun? GetMoveToRun(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveToRun>();
    if (itemElement != null)
      return MoveToRunConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMoveToRun(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, MoveToRun? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveToRun>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MoveToRunConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.MoveToRun>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static RunConflictInsertion? GetRunConflictInsertion(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion>();
    if (itemElement != null)
      return RunConflictInsertionConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRunConflictInsertion(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, RunConflictInsertion? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RunConflictInsertionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static RunConflictDeletion? GetRunConflictDeletion(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion>();
    if (itemElement != null)
      return RunConflictDeletionConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRunConflictDeletion(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, RunConflictDeletion? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RunConflictDeletionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Paragraph? GetParagraph(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Paragraph>();
    if (itemElement != null)
      return Math.ParagraphConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetParagraph(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, Paragraph? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Paragraph>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Math.ParagraphConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Paragraph>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static OfficeMath? GetOfficeMath(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.OfficeMath>();
    if (itemElement != null)
      return OfficeMathConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetOfficeMath(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, OfficeMath? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.OfficeMath>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OfficeMathConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.OfficeMath>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Accent? GetAccent(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Accent>();
    if (itemElement != null)
      return AccentConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetAccent(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, Accent? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Accent>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AccentConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Accent>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Bar? GetBar(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Bar>();
    if (itemElement != null)
      return BarConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBar(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, Bar? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Bar>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BarConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Bar>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Math.Box? GetBox(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Box>();
    if (itemElement != null)
      return Math.BoxConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBox(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, DocumentModel.Math.Box? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Box>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Math.BoxConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Box>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static BorderBox? GetBorderBox(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.BorderBox>();
    if (itemElement != null)
      return BorderBoxConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBorderBox(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, BorderBox? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.BorderBox>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BorderBoxConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.BorderBox>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Delimiter? GetDelimiter(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Delimiter>();
    if (itemElement != null)
      return DelimiterConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDelimiter(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, Delimiter? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Delimiter>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DelimiterConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Delimiter>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static EquationArray? GetEquationArray(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.EquationArray>();
    if (itemElement != null)
      return EquationArrayConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetEquationArray(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, EquationArray? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.EquationArray>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EquationArrayConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.EquationArray>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Fraction? GetFraction(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Fraction>();
    if (itemElement != null)
      return FractionConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFraction(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, Fraction? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Fraction>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FractionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Fraction>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static MathFunction? GetMathFunction(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.MathFunction>();
    if (itemElement != null)
      return MathFunctionConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMathFunction(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, MathFunction? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.MathFunction>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MathFunctionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.MathFunction>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static GroupChar? GetGroupChar(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.GroupChar>();
    if (itemElement != null)
      return GroupCharConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGroupChar(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, GroupChar? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.GroupChar>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GroupCharConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.GroupChar>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static LimitLower? GetLimitLower(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.LimitLower>();
    if (itemElement != null)
      return LimitLowerConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLimitLower(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, LimitLower? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.LimitLower>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LimitLowerConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.LimitLower>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static LimitUpper? GetLimitUpper(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.LimitUpper>();
    if (itemElement != null)
      return LimitUpperConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLimitUpper(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, LimitUpper? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.LimitUpper>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LimitUpperConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.LimitUpper>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Matrix? GetMatrix(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Matrix>();
    if (itemElement != null)
      return MatrixConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMatrix(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, Matrix? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Matrix>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MatrixConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Matrix>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Nary? GetNary(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Nary>();
    if (itemElement != null)
      return NaryConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNary(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, Nary? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Nary>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NaryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Nary>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Phantom? GetPhantom(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Phantom>();
    if (itemElement != null)
      return PhantomConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPhantom(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, Phantom? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Phantom>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PhantomConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Phantom>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Radical? GetRadical(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Radical>();
    if (itemElement != null)
      return RadicalConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRadical(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, Radical? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Radical>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RadicalConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Radical>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static PreSubSuper? GetPreSubSuper(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.PreSubSuper>();
    if (itemElement != null)
      return PreSubSuperConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPreSubSuper(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, PreSubSuper? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.PreSubSuper>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PreSubSuperConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.PreSubSuper>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Subscript? GetSubscript(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Subscript>();
    if (itemElement != null)
      return SubscriptConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSubscript(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, Subscript? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Subscript>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SubscriptConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Subscript>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static SubSuperscript? GetSubSuperscript(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.SubSuperscript>();
    if (itemElement != null)
      return SubSuperscriptConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSubSuperscript(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, SubSuperscript? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.SubSuperscript>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SubSuperscriptConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.SubSuperscript>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Superscript? GetSuperscript(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Superscript>();
    if (itemElement != null)
      return SuperscriptConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSuperscript(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, Superscript? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Superscript>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SuperscriptConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Superscript>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Run? GetRun(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Run>();
    if (itemElement != null)
      return Math.RunConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRun(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, Run? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Run>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Math.RunConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Run>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static BidirectionalOverride? GetBidirectionalOverride(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride>();
    if (itemElement != null)
      return BidirectionalOverrideConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBidirectionalOverride(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, BidirectionalOverride? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BidirectionalOverrideConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static BidirectionalEmbedding? GetBidirectionalEmbedding(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BidirectionalEmbedding>();
    if (itemElement != null)
      return BidirectionalEmbeddingConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBidirectionalEmbedding(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, BidirectionalEmbedding? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BidirectionalEmbedding>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BidirectionalEmbeddingConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.BidirectionalEmbedding>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static RelationshipType? GetSubDocumentReference(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<SubDocumentReference>();
    if (itemElement != null)
      return RelationshipTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSubDocumentReference(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement, RelationshipType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SubDocumentReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RelationshipTypeConverter.CreateOpenXmlElement<SubDocumentReference>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.Hyperlink? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.Hyperlink? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Hyperlink();
      value.TargetFrame = GetTargetFrame(openXmlElement);
      value.Tooltip = GetTooltip(openXmlElement);
      value.DocLocation = GetDocLocation(openXmlElement);
      value.History = GetHistory(openXmlElement);
      value.Anchor = GetAnchor(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.CustomXmlRun = GetCustomXmlRun(openXmlElement);
      value.SimpleFields = GetSimpleFields(openXmlElement);
      value.ChildHyperlink = GetChildHyperlink(openXmlElement);
      value.SdtRun = GetSdtRun(openXmlElement);
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
      value.Run = GetRun(openXmlElement);
      value.BidirectionalOverride = GetBidirectionalOverride(openXmlElement);
      value.BidirectionalEmbedding = GetBidirectionalEmbedding(openXmlElement);
      value.SubDocumentReference = GetSubDocumentReference(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Hyperlink? value)
    where OpenXmlElementType : DocumentFormat.OpenXml.Wordprocessing.Hyperlink, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTargetFrame(openXmlElement, value?.TargetFrame);
      SetTooltip(openXmlElement, value?.Tooltip);
      SetDocLocation(openXmlElement, value?.DocLocation);
      SetHistory(openXmlElement, value?.History);
      SetAnchor(openXmlElement, value?.Anchor);
      SetId(openXmlElement, value?.Id);
      SetCustomXmlRun(openXmlElement, value?.CustomXmlRun);
      SetSimpleFields(openXmlElement, value?.SimpleFields);
      SetChildHyperlink(openXmlElement, value?.ChildHyperlink);
      SetSdtRun(openXmlElement, value?.SdtRun);
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
      SetRun(openXmlElement, value?.Run);
      SetBidirectionalOverride(openXmlElement, value?.BidirectionalOverride);
      SetBidirectionalEmbedding(openXmlElement, value?.BidirectionalEmbedding);
      SetSubDocumentReference(openXmlElement, value?.SubDocumentReference);
      return openXmlElement;
    }
    return default;
  }
}