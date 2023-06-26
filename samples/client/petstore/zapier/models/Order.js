const _ = require('lodash')
const utils = require('../utils/utils');

module.exports = {
    fields: (prefix = '', isInput = true) => {
        let keyPrefix = prefix && `${prefix}${isInput ? '.' : '__'}`
        let labelPrefix = keyPrefix && keyPrefix.replaceAll('__', '.')
        return [
            {
                key: `${keyPrefix}id`,
                label: `[${labelPrefix}id]`,
                type: 'number',
            },
            {
                key: `${keyPrefix}petId`,
                label: `[${labelPrefix}petId]`,
                type: 'number',
            },
            {
                key: `${keyPrefix}quantity`,
                label: `[${labelPrefix}quantity]`,
                type: 'integer',
            },
            {
                key: `${keyPrefix}shipDate`,
                label: `[${labelPrefix}shipDate]`,
                type: 'datetime',
            },
            {
                key: `${keyPrefix}status`,
                label: `Order Status - [${labelPrefix}status]`,
                type: 'string',
                choices: [
                    'placed',
                    'approved',
                    'delivered',
                ],
            },
            {
                key: `${keyPrefix}complete`,
                label: `[${labelPrefix}complete]`,
                type: 'boolean',
            },
        ]
    },
    mapping: (bundle, prefix = '') => {
        let keyPrefix = prefix && `${prefix}.`
        return {
            'id': bundle.inputData?.[`${keyPrefix}id`],
            'petId': bundle.inputData?.[`${keyPrefix}petId`],
            'quantity': bundle.inputData?.[`${keyPrefix}quantity`],
            'shipDate': bundle.inputData?.[`${keyPrefix}shipDate`],
            'status': bundle.inputData?.[`${keyPrefix}status`],
            'complete': bundle.inputData?.[`${keyPrefix}complete`],
        }
    },
}
