# DA.Systems.Cube.Norsk.Model.ShipmentBookingItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NorskBarcode** | **string** | Barcode/identifier allocated for the shipment item   by Norsk may not be displayed on the label. | [optional] 
**Barcode** | **string** | The barcode shown on the label for the shipment item. | [optional] 
**Label** | **byte[]** | Separate label for the shipment item.  Base64 encoded in pdf format. | [optional] 
**ScanBarcode** | **string** | Barcode that is used when scanning an item.  May be different from numeric barcode displayed on the label. | [optional] 
**Weight** | **double** | Weight for the item specified by the booking  May be different from specified depending on dimensions | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

