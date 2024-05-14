const {readFile, writeFile} = require('fs').promises;

const inputFile = process.argv[2];
const outputFile = process.argv[3];
replace().then(() => console.log('Finished.'));

async function replace() {
    
    let openApiDefinitionJson = await readFile(inputFile, 'utf8');
    const openApiDefinition = JSON.parse(openApiDefinitionJson);

    openApiDefinitionJson = JSON.stringify(openApiDefinition, null, '  ');
	
	// Replace generic parameter <T> with C# friendly {T}.
	openApiDefinitionJson = openApiDefinitionJson.replace(/("?description"?\s*:\s*)(.*)<(.*)>(.*)/, '$1$2{$3}$4');
	
    await writeFile(outputFile, openApiDefinitionJson, 'utf8');
}