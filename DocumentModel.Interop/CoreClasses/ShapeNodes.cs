using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shapenodes?view=office-pia"/>
public partial class ShapeNodes: InteropCollection<ShapeNode>
{


  #region methods

/// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shapenodes.delete?view=office-pia"/>
  public void Delete(int Index) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Insert`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <param name="SegmentType">The `SegmentType` parameter.</param>
  /// <param name="EditingType">The `EditingType` parameter.</param>
  /// <param name="X1">The `X1` parameter.</param>
  /// <param name="Y1">The `Y1` parameter.</param>
  /// <param name="X2">The `X2` parameter.</param>
  /// <param name="Y2">The `Y2` parameter.</param>
  /// <param name="X3">The `X3` parameter.</param>
  /// <param name="Y3">The `Y3` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shapenodes.insert?view=office-pia"/>
  public void Insert
  (int Index, SegmentType SegmentType, EditingType EditingType, float X1, float Y1, float X2,
    float Y2, float X3, float Y3) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SetEditingType`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <param name="EditingType">The `EditingType` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shapenodes.seteditingtype?view=office-pia"/>
  public void SetEditingType(int Index, EditingType EditingType) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SetPosition`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <param name="X1">The `X1` parameter.</param>
  /// <param name="Y1">The `Y1` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shapenodes.setposition?view=office-pia"/>
  public void SetPosition(int Index, float X1, float Y1) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SetSegmentType`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <param name="SegmentType">The `SegmentType` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shapenodes.setsegmenttype?view=office-pia"/>
  public void SetSegmentType(int Index, SegmentType SegmentType) { throw new NotImplementedException(); }

  #endregion methods
}

