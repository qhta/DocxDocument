
namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.freeformbuilder?view=office-pia"/>
public partial class FreeformBuilder: InteropObject
{


  #region methods

/// <summary>
  /// Adds one or more nodes to the freeform being built.
  /// </summary>
  /// <param name="SegmentType">The `SegmentType` parameter.</param>
  /// <param name="EditingType">The `EditingType` parameter.</param>
  /// <param name="X1">The `X1` parameter.</param>
  /// <param name="Y1">The `Y1` parameter.</param>
  /// <param name="X2">The `X2` parameter.</param>
  /// <param name="Y2">The `Y2` parameter.</param>
  /// <param name="X3">The `X3` parameter.</param>
  /// <param name="Y3">The `Y3` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.freeformbuilder.addnodes?view=office-pia"/>
  public void AddNodes
  (SegmentType SegmentType, EditingType EditingType, float X1, float Y1, float X2, float Y2,
    float X3, float Y3) { throw new NotImplementedException(); }
  /// <summary>
  /// Converts the freeform builder into a Shape object.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.freeformbuilder.converttoshape?view=office-pia"/>
  public Shape ConvertToShape() { throw new NotImplementedException(); }

  #endregion methods
}

