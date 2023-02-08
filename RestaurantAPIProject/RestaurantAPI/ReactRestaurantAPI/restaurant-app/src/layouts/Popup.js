import React from 'react'
import { Dialog, DialogTitle,DialogContent,makeStyles,Typography,IconButton } from '@mui/material'
import CloseIcon from '@mui/icons-material/Close';

const useStyles = makeStyles(theme => ({
    dialogWrapper: {
        padding: theme.spacing(2),
        position: 'absolute',
        top: theme.spacing(5)
    },
    dialogTitle: {
        paddingRight: '0px'
    }
}))

export default function Popup(props) {

    const { title, children, openPopup, setOpenPopup } = props;
    const classes = useStyles();

    return (

        <Dialog open={openPopup} maxWidth="md" classes={{ paper: classes.dialogWrappper }}>
            <DialogTitle className={classes.dialogTitle}>
                <div style={{ display: 'flex' }}>
                    <Typography variant="h6" component="div" style={{ flexGrow: 1 }}>
                        {title}
                        </Typography>
                        <iconButton
                        onClick={() => { setOpenPopup(false) }}>
                            <CloseIcon />
                            </iconButton>
                            </div>
                            </DialogTitle>
                            <DialogContent dividers>
                                {children}
                            </DialogContent>
                        </Dialog>
    )
}