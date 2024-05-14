# DA.Systems.Cube.Norsk.Model.Shipment

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NorskBarcode** | **string** | Barcode/identifier allocated for the shipment  by Norsk for tracking of the shipment.  May not be displayed on the label. | [optional] [readonly] 
**Barcode** | **string** | the barcode shown on the shipment label. | [optional] [readonly] 
**Hawb** | **string** | The Hawb (House Airway Bill) is your own unique reference number for the shipment, for example it could be the order reference. | [optional] [readonly] 
**Status** | [**NarrativeVm**](NarrativeVm.md) |  | [optional] 
**Narrative** | [**List&lt;NarrativeVm&gt;**](NarrativeVm.md) | History of shipment statuses | [optional] [readonly] 
**ProofOfDelivery** | [**ProofOfDelivery**](ProofOfDelivery.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

