from setuptools import setup, find_packages

setup(
    name='apiverve_captchagenerator',
    version='1.2.2',
    packages=find_packages(),
    include_package_data=True,
    install_requires=[
        'requests',
        'setuptools'
    ],
    description='Captcha Generator generates visual captcha challenges with signed image URLs and text solutions. Each request delivers a challenge image, its correct answer string, an expiration timestamp, and a unique identifier.',
    author='APIVerve',
    author_email='hello@apiverve.com',
    url='https://apiverve.com/marketplace/captchagenerator?utm_source=pypi&utm_medium=referral&utm_content=homepage',
    classifiers=[
        'Programming Language :: Python :: 3',
        'Operating System :: OS Independent',
    ],
    python_requires='>=3.6',
)
