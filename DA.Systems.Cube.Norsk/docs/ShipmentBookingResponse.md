# DA.Systems.Cube.Norsk.Model.ShipmentBookingResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Barcode** | **string** | the barcode shown on the shipment label. | [optional] 
**Label** | **byte[]** | Consolidated multi page pdf of the label and archive documents.  Base64 encoded copy of the default shipment labels in 6x4 in PDF format | [optional] 
**NorskBarcode** | **string** | Barcode/identifier allocated for the shipment  by Norsk for tracking of the shipment.  May not be displayed on the label. | [optional] 
**Items** | [**List&lt;ShipmentBookingItem&gt;**](ShipmentBookingItem.md) | A collection containing details for each shipment item | [optional] 
**ArchiveDocuments** | [**List&lt;ShipmentArchiveDocument&gt;**](ShipmentArchiveDocument.md) | A collection of any non label documents to go with the shipment. | [optional] 
**CollectionReferenceNumber** | **string** | Supplier collection reference number for shipment with collection.  Will be null for non collection shipment | [optional] 
**CollectionDateTime** | **DateTimeOffset?** | Supplier collection date with time number for shipment with collection.  Will be null for non collection shipment | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

