# imports
import aiohttp
import asyncio

# request
async def nani(main_endpoint, sub_endpoint, response_type: 'json'):
    async with aiohttp.ClientSession() as session:
        async with session.get(f'https://nani.red/api/{main_endpoint}/{sub_endpoint}/&type={response_type}/') as r:
            js = await r.json()
            return str(js["response"])

# print async environment
async def main():
    print(await nani("gif", "cuddle"))

# create async environment
loop = asyncio.get_event_loop()
loop.run_until_complete(main())
        
