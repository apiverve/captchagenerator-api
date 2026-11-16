from setuptools import setup, find_packages

setup(
    name='apiverve_captchagenerator',
    version='1.2.6',
    packages=find_packages(),
    include_package_data=True,
    install_requires=[
        'requests',
        'setuptools'
    ],
    description='Captcha Generator creates a new captcha on every call: distorted characters or a simple math question as a GIF or PNG, with the answer to check on your server. Add audio=true for a spoken version, the accessible alternative for visitors who can't see the image.',
    author='APIVerve',
    author_email='hello@apiverve.com',
    url='https://apiverve.com/marketplace/captchagenerator?utm_source=pypi&utm_medium=referral&utm_content=homepage',
    classifiers=[
        'Programming Language :: Python :: 3',
        'Operating System :: OS Independent',
    ],
    python_requires='>=3.6',
)
