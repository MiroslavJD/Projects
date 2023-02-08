import React from 'react'
import {FormControl, InputLabel, MenuItem, FormHelperText} from '@mui/material';


export default function Select(props) {

    const{name, label, value, variant, onChange, options, error=null} = props;

    return (
        <FormControl
        variant={variant || "outlined"}
        {...(error && {error:true})}>
            <InputLabel>{label}</InputLabel>
            <Select
            label={label}
            name={name}
            value={value}
                onChange={onChange}>
                {
                    options.map(
                    item => (<MenuItem key={item.id} value={item.id}>{item.title}</MenuItem>)
                    )
                }
            </Select>
            {error && <FormHelperText>{error}</FormHelperText>}
        </FormControl>
    )
}