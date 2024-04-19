# Trip Scraper API

[![Oxylabs promo code](https://user-images.githubusercontent.com/129506779/250792357-8289e25e-9c36-4dc0-a5e2-2706db797bb5.png)](https://oxylabs.go2cloud.org/aff_c?offer_id=7&aff_id=877&url_id=112)

[![](https://dcbadge.vercel.app/api/server/eWsVUJrnG5)](https://discord.gg/GbxmdGhZjq)

Oxylabs’ [Trip Scraper](https://oxylabs.io/products/scraper-api/web/trip?utm_source=github&utm_medium=repositories&utm_campaign=product) is a data gathering solution allowing you to extract real-time information from a Trip.com website effortlessly. This brief guide explains how a Trip Scraper works and provides code examples to understand better how you can use it hassle-free.

### How it works

You can get Trip results by providing your own URLs to our service. We can return the HTML for any Trip page you like.

#### Python code example

The example below illustrates how you can get HTML of Trip page.

```python
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
```
Find code examples for other programming languages [**here**](https://github.com/oxylabs/trip-scraper/tree/main/code%20examples)

#### Output Example
```json
{
  "results": [
    {
      "content": "<!DOCTYPE html><html lang=\"en-XX\" data-idc=\"SHARB\" style=\"font-size:57.5px\" data-cargo=\"locale:en-XX ... </html>",
      "created_at": "2023-12-18 11:21:22",
      "updated_at": "2023-12-18 11:21:24",
      "page": 1,
      "url": "https://www.trip.com/flights?locale=en-xx&allianceid=742331&sid=2506234&ppcid=adid-660427218467_akid-kwd-11635721_adgid-144762786930&utm_source=google&utm_medium=cpc&utm_campaign=sitelink&utm_extensiontype=sitelink&utm_extension=flight&gad_source=1&gclid=cj0kcqia7oqrbhd9arisak3uxh0t8thl3l86ic0h1fo1wind3utjhjhrafxiu3yeyfc3trwbfv4pz0kaahvlealw_wcb",
      "job_id": "7142473917087645697",
      "status_code": 200
    }
  ]
}
```
With our Trip Scraper, you can smoothly glean public information from any Trip.com web page. Draw out crucial travel specifics such as flight details, hotel bookings, eateries, or locations, to plan your journey seamlessly and stay updated on your travel plan. If you encounter any hiccups, get in touch with our support team via live chat or email us at hello@oxylabs.io.
