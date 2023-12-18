import fetch from 'node-fetch';

const username = 'YOUR_USERNAME';
const password = 'YOUR_PASSWORD';
const body = {
  'source': 'universal',
  'url': 'https://www.trip.com/flights?locale=en-xx&allianceid=742331&sid=2506234&ppcid=adid-660427218467_akid-kwd-11635721_adgid-144762786930&utm_source=google&utm_medium=cpc&utm_campaign=sitelink&utm_extensiontype=sitelink&utm_extension=flight&gad_source=1&gclid=cj0kcqia7oqrbhd9arisak3uxh0t8thl3l86ic0h1fo1wind3utjhjhrafxiu3yeyfc3trwbfv4pz0kaahvlealw_wcb'};
  
const response = await fetch('https://realtime.oxylabs.io/v1/queries', {
  method: 'post',
  body: JSON.stringify(body),
  headers: {
    'Content-Type': 'application/json',
    'Authorization': 'Basic ' + Buffer.from(`${username}:${password}`).toString('base64'),
  }
});

console.log(await response.json());