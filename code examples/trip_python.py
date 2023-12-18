import requests
from pprint import pprint

# Structure payload.
payload = {
    'source': 'universal',
    'url': 'https://www.trip.com/flights?locale=en-xx&allianceid=742331&sid=2506234&ppcid=adid-660427218467_akid-kwd-11635721_adgid-144762786930&utm_source=google&utm_medium=cpc&utm_campaign=sitelink&utm_extensiontype=sitelink&utm_extension=flight&gad_source=1&gclid=cj0kcqia7oqrbhd9arisak3uxh0t8thl3l86ic0h1fo1wind3utjhjhrafxiu3yeyfc3trwbfv4pz0kaahvlealw_wcb'
}

# Get response.
response = requests.request(
    'POST',
    'https://realtime.oxylabs.io/v1/queries',
    auth=('user', 'pass1'),
    json=payload,
)

# Instead of response with job status and results url, this will return the
# JSON response with the result.
pprint(response.json())