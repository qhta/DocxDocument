namespace DocumentModel;

/// <summary>
/// Represents a collection of classification extensions that define custom metadata classifications
/// for Office documents. Classification extensions enable organizations to implement document classification
/// schemes, sensitivity labels, and compliance metadata that integrates with Office's information protection
/// and governance features.
/// </summary>
/// <remarks>
/// <para>
/// Classification extensions are part of Office's extensibility framework for document metadata and
/// information protection. They allow organizations to:
/// <list type="bullet">
/// <item><description><b>Document classification:</b> Apply custom classification schemes (Public, Internal, Confidential, Secret)</description></item>
/// <item><description><b>Sensitivity labels:</b> Integrate with Microsoft Information Protection and Azure Information Protection</description></item>
/// <item><description><b>Compliance metadata:</b> Store regulatory and governance information with documents</description></item>
/// <item><description><b>Policy enforcement:</b> Enable document handling policies based on classification</description></item>
/// <item><description><b>Custom properties:</b> Extend standard document properties with classification-specific data</description></item>
/// </list>
/// </para>
/// <para>
/// Classification extensions are commonly used for:
/// <list type="bullet">
/// <item><description><b>Data loss prevention (DLP):</b> Mark documents with sensitivity levels to prevent unauthorized sharing</description></item>
/// <item><description><b>Regulatory compliance:</b> Tag documents with GDPR, HIPAA, or industry-specific classifications</description></item>
/// <item><description><b>Information governance:</b> Implement retention policies and lifecycle management</description></item>
/// <item><description><b>Access control:</b> Define who can view, edit, or share documents based on classification</description></item>
/// <item><description><b>Audit trails:</b> Track document handling and access based on classification metadata</description></item>
/// <item><description><b>Visual marking:</b> Apply headers, footers, or watermarks based on classification level</description></item>
/// </list>
/// </para>
/// <para>
/// Each <see cref="ClassificationExtension"/> in the collection typically defines:
/// <list type="bullet">
/// <item><description><b>Classification identifier:</b> Unique ID for the classification scheme or label</description></item>
/// <item><description><b>Display name:</b> User-friendly label for the classification</description></item>
/// <item><description><b>Description:</b> Explanation of what the classification means</description></item>
/// <item><description><b>Metadata values:</b> Key-value pairs for classification-specific properties</description></item>
/// <item><description><b>Policy references:</b> Links to organizational policies or compliance requirements</description></item>
/// </list>
/// </para>
/// <para>
/// Classification extensions integrate with Office features:
/// <list type="bullet">
/// <item><description><b>Information Rights Management (IRM):</b> Enforce encryption and access restrictions</description></item>
/// <item><description><b>Azure Information Protection (AIP):</b> Sync classifications with cloud-based protection services</description></item>
/// <item><description><b>Microsoft 365 Compliance Center:</b> Report and monitor classified documents</description></item>
/// <item><description><b>SharePoint and OneDrive:</b> Apply consistent classifications across document repositories</description></item>
/// <item><description><b>Exchange and Outlook:</b> Extend classifications to email attachments</description></item>
/// </list>
/// </para>
/// <para>
/// The classification extension list is typically stored in the document's custom XML parts or
/// document properties, allowing classifications to persist with the document across different
/// systems and applications. This ensures that document handling policies and protections remain
/// in effect regardless of where the document is stored or accessed.
/// </para>
/// <para>
/// Organizations implementing classification extensions should consider:
/// <list type="bullet">
/// <item><description>Developing a clear, consistent classification taxonomy</description></item>
/// <item><description>Training users on classification meanings and appropriate usage</description></item>
/// <item><description>Implementing automated classification where possible (based on content, location, or user)</description></item>
/// <item><description>Regularly auditing classified documents for compliance</description></item>
/// <item><description>Integrating classifications with broader information governance strategies</description></item>
/// </list>
/// </para>
/// </remarks>
/// <example>
/// <code>
/// // Create a classification extension list for sensitivity labels
/// var classificationList = new ClassificationExtensionList
/// {
///     ClassificationExtensions = new Collection&lt;ClassificationExtension&gt;
///     {
///         new ClassificationExtension
///         {
///             Name = "SensitivityLabel",
///             Id = "Confidential",
///             Value = "This document contains confidential information"
///         },
///         new ClassificationExtension
///         {
///             Name = "ComplianceTag",
///             Id = "GDPR",
///             Value = "Contains personal data subject to GDPR"
///         }
///     }
/// };
/// 
/// // Classification list for regulatory compliance
/// var regulatoryClassifications = new ClassificationExtensionList
/// {
///     ClassificationExtensions = new Collection&lt;ClassificationExtension&gt;
///     {
///         new ClassificationExtension
///         {
///             Name = "DataClassification",
///             Id = "PHI",
///             Value = "Protected Health Information - HIPAA compliant"
///         },
///         new ClassificationExtension
///         {
///             Name = "RetentionPeriod",
///             Id = "7years",
///             Value = "Document must be retained for 7 years"
///         },
///         new ClassificationExtension
///         {
///             Name = "HandlingInstructions",
///             Id = "Encrypted",
///             Value = "Must be stored encrypted and transmitted via secure channels"
///         }
///     }
/// };
/// 
/// // Enterprise information protection classification
/// var enterpriseClassification = new ClassificationExtensionList
/// {
///     ClassificationExtensions = new Collection&lt;ClassificationExtension&gt;
///     {
///         new ClassificationExtension
///         {
///             Name = "AIPLabel",
///             Id = "Highly Confidential",
///             Value = "Internal use only - do not share externally"
///         },
///         new ClassificationExtension
///         {
///             Name = "ProjectCode",
///             Id = "ProjectX",
///             Value = "Associated with confidential Project X"
///         }
///     }
/// };
/// </code>
/// </example>
public interface ClassificationExtensionList :
{
  /// <summary>
  /// Gets or sets the collection of classification extensions that define document classifications,
  /// sensitivity labels, and compliance metadata.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The collection of classification extensions stores all classification-related metadata for the document.
  /// Each extension represents a specific classification aspect, such as:
  /// <list type="bullet">
  /// <item><description><b>Sensitivity level:</b> Public, Internal, Confidential, Restricted, Secret</description></item>
  /// <item><description><b>Regulatory tags:</b> GDPR, HIPAA, PCI-DSS, SOX, industry-specific classifications</description></item>
  /// <item><description><b>Information type:</b> Financial data, Personal information, Trade secrets, Legal documents</description></item>
  /// <item><description><b>Handling instructions:</b> Encryption requirements, sharing restrictions, retention policies</description></item>
  /// <item><description><b>Project associations:</b> Project codes, department tags, security clearance levels</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Multiple classification extensions can be applied to a single document, allowing for:
  /// <list type="bullet">
  /// <item><description><b>Multi-dimensional classification:</b> Combine sensitivity level with regulatory requirements</description></item>
  /// <item><description><b>Layered protection:</b> Apply multiple policies simultaneously (encryption + retention + access control)</description></item>
  /// <item><description><b>Rich metadata:</b> Store comprehensive classification information for complex compliance scenarios</description></item>
  /// <item><description><b>Policy inheritance:</b> Derive document handling rules from multiple classification sources</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// The collection is typically populated by:
  /// <list type="bullet">
  /// <item><description><b>User selection:</b> Users manually apply sensitivity labels through Office UI</description></item>
  /// <item><description><b>Automatic classification:</b> Machine learning or rule-based systems analyze content and apply labels</description></item>
  /// <item><description><b>Template inheritance:</b> Documents created from classified templates inherit classifications</description></item>
  /// <item><description><b>Policy enforcement:</b> Administrative policies automatically classify documents based on location or content</description></item>
  /// <item><description><b>API integration:</b> Custom applications or workflows apply classifications programmatically</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Applications reading classification extensions should:
  /// <list type="bullet">
  /// <item><description>Validate that they recognize and can enforce the classification types</description></item>
  /// <item><description>Apply appropriate restrictions and protections based on classifications</description></item>
  /// <item><description>Display classification indicators to users (visual markings, status indicators)</description></item>
  /// <item><description>Log access and operations on classified documents for audit purposes</description></item>
  /// <item><description>Prevent operations that violate classification policies (unauthorized sharing, printing)</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Common patterns for managing classification collections:
  /// <list type="bullet">
  /// <item><description><b>Single primary classification:</b> One main sensitivity label with supporting metadata extensions</description></item>
  /// <item><description><b>Hierarchical classifications:</b> Multiple levels like Department > Project > Document Type</description></item>
  /// <item><description><b>Compliance matrix:</b> Multiple regulatory classifications for multi-jurisdiction documents</description></item>
  /// <item><description><b>Lifecycle tags:</b> Classification extensions that change as document moves through workflow stages</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// The collection persists with the document, ensuring that:
  /// <list type="bullet">
  /// <item><description>Classifications remain attached when documents are copied, moved, or shared</description></item>
  /// <item><description>Protections and policies continue to apply across different storage locations</description></item>
  /// <item><description>Audit trails can track the entire lifecycle of classified documents</description></item>
  /// <item><description>Compliance requirements are maintained even when documents leave organizational boundaries</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// When working with classification collections, consider:
  /// <list type="bullet">
  /// <item><description>Performance impact of storing and reading multiple classifications</description></item>
  /// <item><description>Synchronization with central classification services (Azure Information Protection, etc.)</description></item>
  /// <item><description>Version control and history of classification changes</description></item>
  /// <item><description>Conflict resolution when multiple systems apply conflicting classifications</description></item>
  /// <item><description>Removal or downgrade policies when document sensitivity changes</description></item>
  /// </list>
  /// </para>
  /// </remarks>
  public Collection<ClassificationExtension>? ClassificationExtensions { get; set; }
}